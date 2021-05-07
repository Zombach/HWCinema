using HWCinema.CoreFolders;
using NUnit.Framework;
using System.Collections.Generic;

namespace HWCinema.Tests.HallManagement.Tests
{
    public class HallsManagementTests
    {//NamespaceDefinition does  not correspond to the file local
        [TestCaseSource(typeof(AddHallsTestSource))]
        public void AddingHall_WhenAdding_GeneralListHalls(List<Hall> actual, Hall hall, List<Hall> expected)
        {
            actual.Add(hall);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(RemoveHallsTestSource))]
        public void RemovingHall_WhenAdding_GeneralListHalls(List<Hall> actual, Hall hall, List<Hall> expected)
        {
            actual.Remove(hall);
            Assert.AreEqual(expected, actual);
        }
    }    
}