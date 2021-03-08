using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThirdParty.Json.LitJson;

namespace Myprop
{
    class MyPropManager
    {
        Dictionary<int, Prop> d_Props = new Dictionary<int, Prop>();
        string path = @"D:\C#项目\C#learning\序列化反序列化\Myprop\MyProp.json";
        public Myprop myprop = new Myprop();
        public void Init()
        {
            myprop = JsonHelper.ToObject<Myprop>(path);
            for (int i = 0; i < myprop.props.Count; i++)
            {
                if (!d_Props.ContainsKey(myprop.props[i].id))
                {
                    d_Props.Add(myprop.props[i].id, myprop.props[i]);
                }
                else
                {
                    return;
                }
            }
        }
        public List<Prop> GetAll()
        {
            if (myprop.props.Count > 0)
            {
                return myprop.props;
            }
            else
                return null;
        }
        public Prop Get(int id)
        {
            if (d_Props.ContainsKey(id))
            {
                return d_Props[id];
            }
            else
            {
                return null;
            }
        }
        public bool Add(Prop p)
        {
            if (!d_Props.ContainsKey(p.id))
            {
                d_Props.Add(p.id, p);
                myprop.props = d_Props.Values.ToList();
                JsonHelper.ToJson<Myprop>(myprop,path);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Remove(int id)
        {
            if (d_Props.ContainsKey(id))
            {
                d_Props.Remove(id);
                myprop.props=d_Props.Values.ToList();
                JsonHelper.ToJson<Myprop>(myprop, path);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Updata(int id,bool isUse)
        {
            if (d_Props.ContainsKey(id))
            {
                d_Props[id].isUse = isUse;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
