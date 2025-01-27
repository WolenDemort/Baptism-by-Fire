using System;


namespace SimplePrefs
{

    [AttributeUsage(AttributeTargets.Field)]
    public class SaveFieldAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class, AllowMultiple = false)]
    public class SaveFieldPrimaryKeyAttribute : Attribute
    {

        private string _keyPrimary; // presents a data in a storage by a type (girl, player, etc.)

        public SaveFieldPrimaryKeyAttribute(string keyPrimary)
        {
            if (keyPrimary.Length == 0)
                throw new ArgumentException("The key must be nut null and has lenght more than 0");

            _keyPrimary = keyPrimary;
        }

        public string keyPrimary => _keyPrimary;

    }

    [AttributeUsage(AttributeTargets.Field)]
    public class SaveFieldSecondaryKeyAttribute : Attribute
    {

    }

}