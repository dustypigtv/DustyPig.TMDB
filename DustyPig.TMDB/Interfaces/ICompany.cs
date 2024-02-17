using DustyPig.REST;
using DustyPig.TMDB.Models.Company;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICompany
{
	/// <summary>
	/// Get the company details by ID.
	/// </summary>
	public Task<Response<AlternativeNamesResponse>> GetAlternativeNamesAsync(int companyId, CancellationToken cancellationToken = default);

	/// <summary>
	/// Get the company details by ID.
	/// </summary>
	public Task<Response<DetailsResponse>> GetDetailsAsync(int companyId, CancellationToken cancellationToken = default);

	/// <summary>
	/// Get the company logos by id.
	/// </summary>
	public Task<Response<ImagesResponse>> GetImagesAsync(int companyId, CancellationToken cancellationToken = default);
}
