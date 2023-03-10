namespace FlightAdvisorService.Services;

public interface ICityService
{
    Task<ServiceResponse<List<GetCityDto>>> GetCities();
    Task<ServiceResponse<GetCityDto>> CreateCity(CreateCityDto body);
    Task<ServiceResponse<List<GetAirportDto>>> GetAirportsInCity(string byName);
    Task<ServiceResponse<GetAirportDto>> CreateAirportInCity(int id, CreateAirportDto body);

    Task<ServiceResponse<GetCommetDto>> CreateCommentInCity(int id, CreateCommentDto body);

    Task<ServiceResponse<GetCommetDto>> UpdateCommentInCity(
        int cid,
        int cmid,
        UpdateCommnetDto body
    );

    Task<ServiceResponse<GetCommetDto>> DeleteCommentInCity(int id, int cid);

    Task<ServiceResponse<List<GetCityDto>>> SearchCity(SearchCityDto body, int cLimit);

    Task<ServiceResponse<GetCityDto>> GetUpcomingTrips();

    Task<ServiceResponse<GetTripDto>> CreateTrip(CreateTripDto body);

    Task<ServiceResponse<List<GetTripDto>>> GetTrips(string from, string to);
}
