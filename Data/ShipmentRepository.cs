using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ShipmentTrackingApi.Models;

namespace ShipmentTrackingApi.Data
{
    public class ShipmentRepository
    {
        private readonly string _connectionString;

        public ShipmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<ShipmentStatus>> GetLatestShipmentStatusByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            using IDbConnection dbConnection = new SqlConnection(_connectionString);
            var parameters = new { StartDate = startDate, EndDate = endDate };
            var result = await dbConnection.QueryAsync<ShipmentStatus>("GetLatestShipmentStatusByDateRange", parameters, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
