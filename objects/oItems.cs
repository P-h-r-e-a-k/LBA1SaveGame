﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Globalization;

namespace LBA1SaveGame
{
    class SaveGame
    {
        private Item[] saveGame;

        public SaveGame()
        {
            saveGame = loadItems();
        }

        private Item[] loadItems()
        {
            string filePath = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath + "\\files\\saveGame.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/savegame/item");
            Item[] items = new Item[nodes.Count];
            for (int i = 0; i < items.Length; i++)
                items[i] = getItem(nodes[i]);
            return items;
        }
        private Item getItem(XmlNode xn)
        {
            Item item = new Item();
            item.ID = byte.Parse(xn.Attributes["id"].Value.Trim());
            item.description = xn.Attributes["description"].Value;
            item.memoryOffsetStart = getValOrZero(xn.SelectSingleNode("memoryOffsetStart").InnerText.Trim());
            item.memoryOffsetEnd = getValOrZero(xn.SelectSingleNode("memoryOffsetEnd").InnerText.Trim());
            item.fileOffsetStart = getValOrZero(xn.SelectSingleNode("fileOffsetStart").InnerText.Trim());
            item.fileOffsetEnd = getValOrZero(xn.SelectSingleNode("fileOffsetEnd").InnerText.Trim());
            item.numOfBytes = (byte)getValOrZero(xn.SelectSingleNode("numOfBytes").InnerText.Trim());
            item.fixedValue = (byte)getValOrZero(xn.SelectSingleNode("fixedValue").InnerText.Trim());
            return item;
        }
        //Returns either the integer value of val, or 0 if conversion fails
        private uint getValOrZero(string val)
        {
            if(uint.TryParse(val, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uint result)) return result;
            return 0;
        }

        public bool save(string saveFilePath)
        {
            mem m = new mem();
            for(ushort i = 0; i < saveGame.Length;i++)
                saveGame[i].data = getData(m, saveGame[i]);
            saveFilePath += "\\" +  m.getString(0x1CAA4).ToLower();
            writeFile(saveFilePath, saveGame);
            return true;
        }

        private bool writeFile(string path, Item[] saveGame)
        {
            //path = @"R:\test.lba";
            new FileInfo(path) { IsReadOnly = false }.Refresh();
            FileStream fsFile = new FileStream(path, FileMode.OpenOrCreate,
            FileAccess.Write);

            for (int i = 0; i < saveGame.Length; i++)
            {
                for(int j=0; j< saveGame[i].data.Length;j++)
                    fsFile.WriteByte(saveGame[i].data[j]);
            }
            fsFile.Flush();
            fsFile.Close();
            new FileInfo(path) { IsReadOnly = true }.Refresh();

            return true;
        }
        private byte[] getData(mem m, Item item)
        {
            //If fixedValue
            if (0 == item.memoryOffsetStart)
                return getConstant(item);
            //If Filename - if end offset is 0 and we have a start object this is the filename
            if (item.memoryOffsetEnd < item.memoryOffsetStart)
                return getFilename(m, item);
            if (0 != item.memoryOffsetStart && 0 != item.memoryOffsetEnd)
                return getByteArray(m, item);
            return null;
        }

        private byte[] getConstant(Item item)
        {
            byte[] data;
            ushort arraySize = (ushort)((item.fileOffsetEnd - item.fileOffsetStart) + 1); //(11 - 1 = 10, we need to be inclusive)
            data = new byte[arraySize];
            for (ushort i = 0; i < data.Length; i++)
                data[i] = item.fixedValue;
            return data;
        }
        private byte[] getFilename(mem m, Item item)
        {
            return m.getByteArrayNull(item.memoryOffsetStart);
        }
        private byte[] getByteArray(mem m, Item item)
        {
            byte arraySize = (byte)((item.fileOffsetEnd - item.fileOffsetStart) + 1); //(11 - 1 = 10, we need to be inclusive)
            return m.getByteArray(item.memoryOffsetStart, arraySize);
 
        }
    }

}
