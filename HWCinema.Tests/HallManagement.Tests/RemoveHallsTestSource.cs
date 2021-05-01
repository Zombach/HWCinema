using HWCinema.CoreFolders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.Tests.HallManagement.Tests
{
    public class RemoveHallsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List <Hall>
                {
                    new Hall("Вознесения"),
                    new Hall("Большой"),
                    new Hall("Звездный")
                },
                new Hall("Большой"),
                new List <Hall>
                {
                    new Hall("Вознесения"),
                    new Hall("Звездный"),
                }
            };
            yield return new object[]
            {
                new List <Hall>
                {
                    new Hall("Большой"),
                    new Hall("Малый"),
                    new Hall("Звездный")
                },
                new Hall("Большой"),
                new List <Hall>
                {
                    new Hall("Малый"),
                    new Hall("Звездный"),
                }
            };
            yield return new object[]
            {
                new List <Hall>
                {
                    new Hall("Круглый"),
                    new Hall("Детский"),
                    new Hall("Малый")
                },
                    new Hall("Малый"),
                new List <Hall>
                {
                    new Hall("Круглый"),
                    new Hall("Детский"),
                }
            };
        }
    }
}
