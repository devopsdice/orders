namespace Order.Repository.Constants
{
    public static class OrderRepositoryConstant
    {
        public const string Insert = @"INSERT INTO public.""Order"" (""ProductId"",""Quantity"",""Status"")VALUES(@ProductId,@Quantity,@Status) RETURNING ""OrderId"";";
        public const string Update = @"Update public.""Order"" set ""Status""=@Status where ""OrderId""=@OrderId;";

    }
}
