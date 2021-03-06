using System;
using System.Threading.Tasks;
using InfluxDB.Client.Api.Domain;
using InfluxDB.Client.Api.Service;
using InfluxDB.Client.Core;

namespace InfluxDB.Client
{
    public class DeleteApi
    {
        private readonly DefaultService _service;

        protected internal DeleteApi(DefaultService service)
        {
            Arguments.CheckNotNull(service, nameof(service));

            _service = service;
        }
        
        /// <summary>
        /// Delete Time series data from InfluxDB.
        /// </summary>
        /// <param name="start">Start time</param>
        /// <param name="stop">Stop time</param>
        /// <param name="predicate">Sql where like delete statement</param>
        /// <param name="bucket">The bucket from which data will be deleted</param>
        /// <param name="org">The organization of the above bucket</param>
        public async Task Delete(DateTime start, DateTime stop, string predicate, Bucket bucket, Organization org)
        {
            Arguments.CheckNotNull(start, "Start is required");
            Arguments.CheckNotNull(stop, "Stop is required");
            Arguments.CheckNotNull(predicate, "Predicate is required");
            Arguments.CheckNotNull(bucket, "Bucket is required");
            Arguments.CheckNotNull(org, "Organization is required");
            
            await Delete(start, stop, predicate, bucket.Id, org.Id);
        }
        
        /// <summary>
        /// Delete Time series data from InfluxDB.
        /// </summary>
        /// <param name="start">Start time</param>
        /// <param name="stop">Stop time</param>
        /// <param name="predicate">Sql where like delete statement</param>
        /// <param name="bucket">The bucket from which data will be deleted</param>
        /// <param name="org">The organization of the above bucket</param>
        public async Task Delete(DateTime start, DateTime stop, string predicate, string bucket, string org)
        {
            Arguments.CheckNotNull(start, "Start is required");
            Arguments.CheckNotNull(stop, "Stop is required");
            Arguments.CheckNotNull(predicate, "Predicate is required");
            Arguments.CheckNonEmptyString(bucket, "Bucket is required");
            Arguments.CheckNonEmptyString(org, "Organization is required");
            
            var predicateRequest = new DeletePredicateRequest(start, stop, predicate);

            await Delete(predicateRequest, bucket, org);
        }

        /// <summary>
        /// Delete Time series data from InfluxDB.
        /// </summary>
        /// <param name="predicate">Predicate delete request</param>
        /// <param name="bucket">The bucket from which data will be deleted</param>
        /// <param name="org">The organization of the above bucket</param>
        public async Task Delete(DeletePredicateRequest predicate, string bucket, string org)
        {
            Arguments.CheckNotNull(predicate, "Predicate is required");
            Arguments.CheckNonEmptyString(bucket, "Bucket is required");
            Arguments.CheckNonEmptyString(org, "Organization is required");
            
            await _service.DeletePostAsync(predicate, null, org, bucket);
        }
    }
}