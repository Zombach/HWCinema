using NUnit.Framework;
using System.Collections;
using HWCinema.CoreFolders;
using System.Collections.Generic;
using HWCinema.Tests.HallManagement.Tests;

namespace HWCinema.Tests.HallsManagement.Tests
{
    public class HallsManagementTests
    {
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