using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    public interface ISports
    {
        void PingPang();
    }

    public interface IWork
    {
        void Work();
    }

    public class People
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Chinese : People, ISports, IWork
    {
        public void PingPang()
        {

        }

        public void Work()
        {

        }
    }

    public class HuBei : Chinese
    {
        public string ChangJiang { get; set; }

        public void MaJiang()
        {

        }
    }

    public class Japanese : ISports
    {
        public void PingPang()
        {

        }
    }

}
