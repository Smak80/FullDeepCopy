using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMK_L2022_03_15
{
    public class SomeClass : IDeepCopyable
    {
        public String str { get; set; }
        public List<ElemClass> list = new();

        public SomeClass()
        {
            str = "SomeStr";
        }

        public void AddElem(ElemClass el)
        {
            list.Add(el);
        }

        public object DeepCopy()
        {
            var newobj = new SomeClass();
            newobj.str = new (str);
            newobj.list = new List<ElemClass>();
            foreach (var el in list)
            {
                var nel = new ElemClass(el.Name);
                newobj.list.Add(nel);
            }

            return newobj;
        }
    }
}
