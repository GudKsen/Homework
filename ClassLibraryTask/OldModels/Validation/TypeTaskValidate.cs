using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.OldModels.Validation
{
    public class TypeTaskValidate
    {
        public string Type { get; set; }
        public TypeTaskValidate() { }
        public TypeTaskValidate(string type) 
        { 
            Type = type;
        }

        public TypeTask Validate()
        {
            if (Type != null)
            {
               switch (Type)
                {
                    case "none":
                        return TypeTask.None;
                    case "theory":
                        return TypeTask.Theory;
                    case "practice":
                        return TypeTask.Practice;
                    case "additional":
                        return TypeTask.Additional;
                }
            }
            return TypeTask.None;
        }
    }
}
