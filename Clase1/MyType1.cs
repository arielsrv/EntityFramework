namespace EF
{
    public partial class MyType
    {
        partial void Before();
        partial void After();
        
        public void X() 
        {
            Before();
            //TODO: rocket launch...
            After();
        }
    }   
}