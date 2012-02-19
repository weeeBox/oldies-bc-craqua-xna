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

        public BcBinaryData LoadBinary(string path)
        {
            using (ContentManager manager = new ContentManager(content.ServiceProvider, "Content"))
            {
                return manager.Load<BcBinaryData>(path);
            }
        }

        //public BitmapFont LoadFont(string path)
        //{
        //    using (ContentManager manager = new ContentManager(content.ServiceProvider, "Content"))
        //    {
        //        return manager.Load<BitmapFont>(path);
        //    }
        //}

        //public GameTexture LoadImage(string resname)
        //{
        //    Texture2D texture = content.Load<Texture2D>(resname);
        //    return new GameTexture(texture);
        //}

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

        //public GameMusic LoadMusic(string resName)
        //{
        //    return new GameMusic(content.Load<Song>(resName));
        //}

        //public GameSound LoadSound(string resName)
        //{
        //    return new GameSound(content.Load<SoundEffect>(resName));
        //}

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
    }
}
