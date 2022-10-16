using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var privates = new List<IPrivate>();
            var spyes=new List<ISpy>();
            var leutenants=new List<ILeutenantGeneral>();
            var engineers = new List<IEngineer>();
            var commandos=new List<ICommando>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "Private")
                {
                    IPrivate ipet = new Private(input);
                    privates.Add(ipet);
                    ipet.Print(ipet);
                }
                else if (input[0] == "Spy")
                {
                    ISpy spy = new Spy(input);
                    spyes.Add(spy);
                    spy.Print(spy);
                }
                else if (input[0] == "LeutenantGeneral")
                {
                    ILeutenantGeneral leutenant = new LeutenantGeneral(input);
                    leutenants.Add(leutenant);
                    leutenant.Print(leutenant,privates);
                }
                else if (input[0] == "Engineer")
                {
                    IEngineer engineer = new Engineer(input);
                    engineers.Add(engineer);
                    engineer.Print(engineer);
                }
                else if (input[0] == "Commando")
                {
                    ICommando commando = new Commando(input);
                    commandos.Add(commando);
                    commando.Print(commando);
                }
                else { break; }
            }
            Console.ReadLine();
        }
    }
    /*Engineer 7 Pencho Penchev 12,23 Marines Boat 2 Crane 17
Commando 19 Penka Ivanova 150,15 Airforces HairyFoot finished Freedom inProgress
End
*/

}
