using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public static class SessionExtensions
    {
        public static T GetComplexData<T>(this ISession session, string key)
        {
            var data = session.GetString(key);
            if (data == null)
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(data);
        }

        public static void SetComplexData(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static string GetCatData(this ISession session, string key)
        {
            var data = session.GetString(key);
            if (data == null)
            {
                return "-1";
            }
            return data;
        }

        public static void SetcatData(this ISession session, string key, String value)
        {
            session.SetString(key, value);
        }
        public static void ClearSession(this ISession session)
        {
            session.Clear();
            



        }

    }
}
