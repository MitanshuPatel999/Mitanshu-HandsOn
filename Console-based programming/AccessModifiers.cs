using System;

namespace AccessModifiers
{
    public class Program
    {
        public static void Main()
        {
            // Create an instance of MyClass
            MyClass myObject = new MyClass();

            // Access public method
            myObject.AccessPrivateField();
            myObject.AccessProtectedField();

            // Access internalField (internal) and protectedInternalField (protected internal)
            Console.WriteLine("Accessing internalField: " + myObject.internalField);
            Console.WriteLine("Accessing protectedInternalField: " + myObject.protectedInternalField);

            // Create an instance of MyDerivedClass
            MyDerivedClass derivedObject = new MyDerivedClass();

            // Access protected members from the derived class
            derivedObject.AccessProtectedMembers();
            Console.WriteLine("Accessing private field indirectly :"+derivedObject.derivedForPrivate());

            // Note: You cannot access privateField directly from here since it's private.
        }
    }
    public class MyClass
    {
        // Private access modifier: Accessible only within this class
        private int privateField = 10;

        // Protected access modifier: Accessible within this class and derived classes
        protected string protectedField = "Hello, World!";

        // Internal access modifier: Accessible within the same assembly
        internal int internalField = 20;

        // Protected internal access modifier: Accessible within the same assembly and derived classes
        protected internal double protectedInternalField = 3.14;

        // Public method with a private field
        public virtual void AccessPrivateField()
        {
            Console.WriteLine("Accessing privateField from a public method: " + privateField);
        }

        // Public method with a protected field
        public void AccessProtectedField()
        {
            Console.WriteLine("Accessing protectedField from a public method: " + protectedField);
        }

        public int AccessPrivate(){
            return privateField;
        }
    }

    // Derived class with access to protected members
    public class MyDerivedClass : MyClass
    {
        public void AccessProtectedMembers()
        {
            // Access protectedField from the base class
            Console.WriteLine("Accessing protectedField from derived class: " + protectedField);
        }

        public int derivedForPrivate(){
            int i =AccessPrivate();
            // int x=privateField;
        return i;
        }
        

                

    }
}
