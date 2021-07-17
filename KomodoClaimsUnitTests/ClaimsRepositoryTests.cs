using KomodoClaimsClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoClaimsUnitTests
{
    [TestClass]
    public class ClaimsRepositoryTests
    {
        private ClaimRepository _repo = new ClaimRepository();
        private Claim _claim = new Claim();

        [TestMethod]
        public void CreateNewClaim_ShouldReturnTrue()
        {
            Claim claim = new Claim();
            claim.ClaimType = "Car";
            ClaimRepository repo = new ClaimRepository();

            bool result = _repo.CreateNewClaim(_claim);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetAllClaims_ShouldNotBeNull()
        {
            Claim _claim = new Claim();
            ClaimRepository _repo = new ClaimRepository();

            bool result = true;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeleteExistingClaims_ShouldReturnFalse()
        {
            Claim _claim = new Claim();
            ClaimRepository _repo = new ClaimRepository();

            bool deleteResult = _repo.DeleleExistingClaims(_claim.ClaimType);

            Assert.IsFalse(deleteResult);
        }
    }
}
            
