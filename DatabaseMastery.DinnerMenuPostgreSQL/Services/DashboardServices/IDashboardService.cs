using DatabaseMastery.DinnerMenuPostgreSQL.Dtos.ReservationDtos;
using DatabaseMastery.DinnerMenuPostgreSQL.Context;

public interface IDashboardService
{
    Task<int> GetTotalReservationCountAsync();
    Task<int> GetPendingReservationCountAsync();
    Task<int> GetApprovedReservationCountAsync();
    Task<int> GetCancelledReservationCountAsync();
    Task<int> GetTodayReservationCountAsync();
    Task<int> GetTotalCustomerCountAsync();
    Task<int> GetTotalMenuProductCountAsync();
    Task<int> GetTodayOrderCountAsync();
    Task<List<ResultReservationDto>> GetTodayReservationListAsync();
}