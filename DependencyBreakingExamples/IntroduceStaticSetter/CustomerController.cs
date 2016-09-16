namespace DependencyBreakingExamples.IntroduceStaticSetter
{
    public class CustomerController
    {

        public void DeleteCustomer(long customerId)
        {

            bool authorized = Permissions.HasPermission("DELETE_CUSTOMER");

            if (!authorized)
            {
                throw new AuthorizationException();
            }

            // ...

        }
    }
}
