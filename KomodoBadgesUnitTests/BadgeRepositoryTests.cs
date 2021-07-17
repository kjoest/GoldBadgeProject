using KomodoBadgesClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoBadgesUnitTests
{
    [TestClass]
    public class BadgeRepositoryTests
    {
        private Badge _badge = new Badge();
        private BadgeRepository _repo = new BadgeRepository();

        [TestMethod]
        public void AddDoors_ShouldNotBeNull()
        {
            Badge _badge = new Badge();
            BadgeRepository _repo = new BadgeRepository();

            bool result = _repo.AddDoors(_badge);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetDoorNames_ShouldReturnNotNull()
        {
            Badge _badge = new Badge();
            BadgeRepository _repo = new BadgeRepository();

            bool result = true;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void UpdateDoorsOnExistingBadge_ShouldReturnTrue(string originalDoor, bool shouldUpdate)
        {
            Badge _badge = new Badge();
            BadgeRepository _repo = new BadgeRepository();

            bool updateResult = _repo.UpDateDoorsOnExistingBadge(originalDoor, _badge);

            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteDoorsFromList_ShouldReturnTrue()
        {
            Badge _badge = new Badge();
            BadgeRepository _repo = new BadgeRepository();

            bool deleteResult = _repo.DeleteDoorsFromList(_badge.DoorNames.ToString());

            Assert.IsTrue(deleteResult);
        }

        [TestMethod]
        public void AddDoorsToList_ShouldGetNotNull()
        {
            Badge _badge = new Badge();
            BadgeRepository _repo = new BadgeRepository();

            bool result = _repo.AddDoorsToList(_badge.ToString());

            Assert.IsNotNull(result);
        }
    }
}
