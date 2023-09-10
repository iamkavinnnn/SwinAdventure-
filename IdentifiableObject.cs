using System;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        public List<string> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();

            foreach (string ident in idents)
            {
                AddIdentifier(ident.ToLower());
            }
        }

        public bool AreYou(string ident)
        {
            if (_identifiers.Contains(ident.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FirstId() 
        {
            if (_identifiers.Count == 0)
            {
                return ""; // Returns empty string because the Case Study says so
            }
            else
            {
                return _identifiers[0];
            }
        }

        public void AddIdentifier(string ID) //stores the identiable objects into identifiers list and converts it to lowercase
        {
            _identifiers.Add(ID.ToLower());
        }
    }
}

