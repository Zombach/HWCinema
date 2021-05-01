using NUnit.Framework;
using System.Collections;
using HWCinema.CoreFolders;
using System.Collections.Generic;

namespace HWCinema.Tests
{
    public class HallsManagementTests
    {
        [TestCaseSource(typeof(AddHallsTestSource))]
        public void ChangeFont_WhenAlways_ShouldChangeFont(List<Hall> actual, Hall hall, List<Hall> expected)
        {
            actual.Add(hall);
            Assert.AreEqual(expected, actual);
        }
    }
    public class AddHallsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List <Hall>
                {
                    new Hall("����������"),
                    new Hall("�������")
                },
                new Hall("��������"),
                new List <Hall>
                {
                    new Hall("����������"),
                    new Hall("�������"),
                    new Hall("��������")
                }
            };
            yield return new object[]
            {
                new List <Hall>
                {
                    new Hall("��������"),
                    new Hall("�����")
                },
                new Hall("�������"),
                new List <Hall>
                {
                    new Hall("��������"),
                    new Hall("�����"),
                    new Hall("�������")
                }
            };
            yield return new object[]
            {
                new List <Hall>
                {
                    new Hall("�������"),
                    new Hall("�������"),
                },
                new Hall("�����"),
                new List <Hall>
                {
                    new Hall("�������"),
                    new Hall("�������"),
                    new Hall("�����")
                }
            };
        }
    }
}