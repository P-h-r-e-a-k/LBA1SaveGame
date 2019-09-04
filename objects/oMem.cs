using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace LBA1SaveGame
{
    class mem
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int hProcess, uint lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(int hProcess, uint lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        const int PROCESS_ALL_ACCESS = 0x1F0FFF;
        const int PROCESS_WM_READ = 0x0010;
        IntPtr processHandle;
        private uint baseAddress = 0;

        public mem()
        {
            OpenProcess(PROCESS_ALL_ACCESS);
        }
        private uint getBaseAddress(byte LBAVer)
        {
            string baseString;
            if (0 != baseAddress) return baseAddress;
            uint readAddr;
            if(1 == LBAVer)
            {
                baseString = "Relent";
                readAddr = 0x0A000FC8;//Base address to start scanning from
            }
            else
            {
                baseString = "Run-Time system.";
                readAddr = 0x0B00003D;
            }

            byte[] b = new byte[baseString.Length];

            for (int i = 0; i <= 0xFFFF; readAddr += 0x1000, i++)
            {
                int bytesRead = 0;

                ReadProcessMemory((int)processHandle, readAddr, b, b.Length, ref bytesRead);
                if (baseString == System.Text.Encoding.UTF7.GetString(b).Trim())
				{
					baseAddress = readAddr;
                    return readAddr;
				}
            }
            return 0;
        }
        #region readProcess
        private bool readProcess(uint addressToRead, ref byte[] data)
        {
            int bytesRead = 0;
            return ReadProcessMemory((int)processHandle, addressToRead, data, data.Length, ref bytesRead);            
        }
        public int readAddress(uint offsetToRead, byte size)
        {
            uint addressToRead = 0;
            byte[] bytes = new byte[size];
            uint baseAddr = getBaseAddress(1); //LBAVer
            if (0 == baseAddr)
                return -1;
            else
                addressToRead = (uint)(offsetToRead + baseAddr);
            if (readProcess(addressToRead, ref bytes))
            {
                if (1 == size)
                    return bytes[0];
                return BitConverter.ToInt16(bytes, 0);
            }
            return 0;
        }
        public int getVal(uint offsetToRead, byte size)
        {
            return readAddress(offsetToRead, size);
        }

        public string getString(uint startOffset)
        {
            string sVal = "";
            int iVal;
            for (int i = 0; 0 != (iVal = readAddress(startOffset++, 1)); i++)
                sVal += Char.ConvertFromUtf32(iVal);
            return sVal;
        }

        //This reads bytes until a null character is encountered
        public byte[] getByteArrayNull(uint startOffset)
        {
            byte[] t = Encoding.UTF8.GetBytes(getString(startOffset));
            byte[] b = new byte[t.Length+1];
            for(byte i = 0; i < t.Length; i++) b[i] = t[i];
            b[b.Length - 1] = 0;
            return b;
        }

        public byte[] getByteArray(uint startOffset, ushort size)
        {
            byte[] b = new byte[size];
            readProcess(getBaseAddress(1) + startOffset, ref b);
            return b;
        }
        //Assigns to proc and ProcessHandle
        #endregion
        #region writeProcess
        private int writeProcess(uint addressToWrite, byte[] buffer, ushort size)
        {
            int bytesWritten = 0;
            WriteProcessMemory((int)processHandle, addressToWrite, buffer, size, ref bytesWritten);
            return bytesWritten;
        }


        public bool writeAddress(uint offset, byte[] bytes)
        {
            uint addressToWrite = offset;
            uint baseAddr = getBaseAddress(1);
            if (0 == baseAddr)
                return false;
            else
                addressToWrite += baseAddr;
            return (!(0 >= writeProcess(addressToWrite, bytes, (ushort)bytes.Length)));
        }

        public void WriteVal(uint offset, ushort val)
        {
            writeAddress(offset, BitConverter.GetBytes(val));
        }
        #endregion
        private void OpenProcess(int access)
        {
            Process[] p;
            p = Process.GetProcessesByName("DOSBox");
            if (1 != p.Length) return;
            processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id); ;
        }
    }
}
