using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using System.Diagnostics;

namespace bc.flash.resources
{
    public class BcResFactory
    {
        private ContentManager content;        
        private Dictionary<string, object> usedReferences;

        private const string EXT_PNG = ".png";
        private const string EXT_JPG = ".jpg";
        private const string EXT_WAV = ".wav";
        private const string EXT_MP3 = ".mp3";
        private const string EXT_XML = ".xml";

        private static BcResFactory instance;

        public BcResFactory(ContentManager content)
        {
            this.content = content;
            usedReferences = new Dictionary<string, object>();

            instance = this;            
        }

        public static BcResFactory GetInstance()
        {
            return instance;
        }

        public AsObject LoadResource(String path)
        {
            String ext = ExtractExt(path);
            if (ext == EXT_PNG || ext == EXT_JPG)
            {
                return LoadImage(path);
            }

            if (ext == EXT_WAV)
            {
                return LoadSound(path);
            }

            if (ext == EXT_MP3)
            {
                return LoadMusic(path);
            }

            if (ext == EXT_XML)
            {
                return LoadXML(path);
            }

            throw new NotImplementedException("Unknown type: " + ext);
        }

        public BcBinaryData LoadBinary(string path)
        {
            using (ContentManager manager = new ContentManager(content.ServiceProvider, "Content"))
            {
                return manager.Load<BcBinaryData>(CreateSafePath(path));
            }
        }

        //public BitmapFont LoadFont(string path)
        //{
        //    using (ContentManager manager = new ContentManager(content.ServiceProvider, "Content"))
        //    {
        //        return manager.Load<BitmapFont>(path);
        //    }
        //}

        public AsObject LoadImage(String path)
        {
            throw new NotImplementedException();
        }

        //public GameTexture LoadManagedImage(string path)
        //{
        //    GameTexture instance = FindUsedReference<GameTexture>(path);
        //    if (instance == null)
        //    {
        //        instance = LoadImage(path);
        //        AddReference(path, instance);
        //    }
        //    return instance;
        //}

        //public AtlasRes loadAtlas(string resName)
        //{
        //    return content.Load<AtlasRes>(resName);
        //}

        //public SwfMovie LoadSwfMovie(string path)
        //{
        //    using (ContentManager manager = new ContentManager(content.ServiceProvider, "Content"))
        //    {
        //        return manager.Load<SwfMovie>(path);
        //    }
        //}

        public AsObject LoadMusic(String path)
        {
            throw new NotImplementedException();
        }

        public AsObject LoadSound(String path)
        {
            throw new NotImplementedException();
        }

        public AsObject LoadXML(String path)
        {
            throw new NotImplementedException();
        }

        //public StringsPack LoadStrings(string path)
        //{
        //    return content.Load<StringsPack>(path);
        //}

        public void Dispose()
        {            
        }

        public T FindUsedReference<T>(string name)
        {
            if (!usedReferences.ContainsKey(name))
                return default(T);
            return (T)usedReferences[name];
        }

        public void AddReference(string name, object obj)
        {
            Debug.Assert(!usedReferences.ContainsKey(name), name);
            usedReferences.Add(name, obj);
        }

        private String CreateSafePath(String path)
        {
            int dotIndex = path.LastIndexOf('.');
            if (dotIndex != -1)
            {
                return path.Substring(0, dotIndex);
            }
            return path;
        }

        private String ExtractExt(String path)
        {
            int dotIndex = path.LastIndexOf('.');
            if (dotIndex != -1)
            {
                return path.Substring(dotIndex, path.Length - dotIndex).ToLower();
            }
            return "";
        }
    }
}
