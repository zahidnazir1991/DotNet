using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public static class util
    {

        public static SelectList ToSelectList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            Hashtable usergroups = new Hashtable();
            usergroups.Add("1", "Administrador");
            usergroups.Add("2", "Reception"); //adding a key/value using the Add() method
            usergroups.Add("3", "House Keeping");
            usergroups.Add("4", "Supervisor");
            usergroups.Add("5", "Maintenance");
            foreach (DictionaryEntry de in usergroups)
            {
                list.Add(new SelectListItem()
                {
                    Text = de.Key.ToString(),
                    Value = de.Value.ToString()
                });
            }
            return new SelectList(list, "Text", "Value");
        }

        public static SelectList SelectList(DataTable table, string valueField, string textField, string defaulttext)
        {
            List<SelectListItem> list = new List<SelectListItem>();


            if (defaulttext.Length > 0)
            {
                list.Add(new SelectListItem()
                {
                    Text = defaulttext,
                    Value = "-1"

                });
            }





            foreach (DataRow row in table.Rows)
            {
                list.Add(new SelectListItem()
                {
                    Text = row[textField].ToString(),
                    Value = row[valueField].ToString()
                });
            }

            return new SelectList(list, "Value", "Text");
        }



        public static SelectList SelectListstatus(DataTable table, string valueField, string textField, string defaulttext)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            if (defaulttext.Length > 0)
            {
                list.Add(new SelectListItem()
                {
                    Text = defaulttext,
                    Value = "-1"
                  


                });
            }


            foreach (DataRow row in table.Rows)
            {
                list.Add(new SelectListItem()
                {
                    Text = row[textField].ToString(),
                    Value = row[valueField].ToString()
                });
            }

            return new SelectList(list, "Value", "Text");
        }


        public static SelectList TostatustypeList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            Hashtable usergroups = new Hashtable();
            usergroups.Add("1", "Image");
            usergroups.Add("2", "Font Awesome");

            foreach (DictionaryEntry de in usergroups)
            {
                list.Add(new SelectListItem()
                {
                    Text = de.Key.ToString(),
                    Value = de.Value.ToString()
                });
            }
            return new SelectList(list, "Text", "Value");
        }

        public static SelectList TostatusprorityhList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            Hashtable usergroups = new Hashtable();
            usergroups.Add("1", "Medium");
            usergroups.Add("2", "High");
            usergroups.Add("3", "Urgent");

            foreach (DictionaryEntry de in usergroups)
            {
                list.Add(new SelectListItem()
                {
                    Text = de.Key.ToString(),
                    Value = de.Value.ToString(),
                   
                });
            }

            list = list.OrderBy(n => n.Text).ToList();
            return new SelectList(list, "Text", "Value");
        }


        public static DataTable ToDataTable<T>(this List<T> iList)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);


                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T iListItem in iList)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }



    }
}
