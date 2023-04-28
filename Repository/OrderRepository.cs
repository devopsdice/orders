
using Dapper;
using Order.Model;
using Order.Repository.Base;
using Order.Repository.Constants;

namespace Order.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDapperContext _context;

        public OrderRepository(IDapperContext context)
        {
            _context = context;
        }


        public async Task<OrderData> SaveOrderAsync(OrderData orderData)
        {

            int result = 0;

            var parameters = new DynamicParameters();
            parameters.Add("@ProductID", orderData.ProductID);
            parameters.Add("@Quantity", orderData.Quantity);
            parameters.Add("@Status", orderData.Status);

            using (var connection = _context.CreateConnection())
            {
                result = await connection.ExecuteScalarAsync<int>(OrderRepositoryConstant.Insert, parameters);
            }
            orderData.OrderId = result;

            return orderData;
        }

        public async Task<int> UpdateOrderAsync(OrderData orderData)
        {

            int result = 0;

            var parameters = new DynamicParameters();
            parameters.Add("@OrderId", orderData.OrderId);
            parameters.Add("@Status", orderData.Status);

            using (var connection = _context.CreateConnection())
            {
                result = await connection.ExecuteScalarAsync<int>(OrderRepositoryConstant.Update, parameters);
            }
            
            return result;
        }
    }
}
