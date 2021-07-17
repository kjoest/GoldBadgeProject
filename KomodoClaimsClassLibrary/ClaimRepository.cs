using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsClassLibrary
{
    public class ClaimRepository
    {
        public Queue<Claim> _queueOfClaims = new Queue<Claim>();

        public bool CreateNewClaim(Claim claim)
        {
            if (claim is null)
            {
                return false;
            }

            _queueOfClaims.Enqueue(claim);
            return true;
        }

        public Queue<Claim> GetAllClaims()
        {
            return _queueOfClaims;
        }

        public Claim DequeueClaim()
        {
            return _queueOfClaims.Dequeue();
        }

        public Claim Peek()
        {
            return _queueOfClaims.Peek();
        }

        public bool DeleleExistingClaims(string existingClaim)
        {
            Claim claim= GetExistingClaimsByType(existingClaim);
            
            if(claim == null)
            {
                return false;
            }

            int initialClaim = _queueOfClaims.Count;

            if (_queueOfClaims.Count < initialClaim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        public Claim GetExistingClaimsByType(string claimType)
        {
            foreach (Claim claim in _queueOfClaims)
            {
                if (claim.ClaimType.ToLower() == claimType.ToLower())
                {
                    return claim;
                }            
            }

            return null;
        }

    }
}

