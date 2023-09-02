using System;

namespace CaseStudy1
{
    class IdentifiableObject
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
                return "";
            }
            else
            {
                return _identifiers[0];
            }
        }

        public void AddIdentifier(string ID)
        {
            _identifiers.Add(ID.ToLower());
        }
    }
}
