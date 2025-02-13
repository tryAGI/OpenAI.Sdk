#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new project in the organization. Projects can be created and archived, but cannot be deleted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Project> CreateProjectAsync(
            global::tryAGI.OpenAI.ProjectCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new project in the organization. Projects can be created and archived, but cannot be deleted.
        /// </summary>
        /// <param name="name">
        /// The friendly name of the project, this name appears in reports.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Project> CreateProjectAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}