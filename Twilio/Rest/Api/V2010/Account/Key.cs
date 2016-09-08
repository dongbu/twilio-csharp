using Newtonsoft.Json;
using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Deleters.Api.V2010.Account;
using Twilio.Exceptions;
using Twilio.Fetchers.Api.V2010.Account;
using Twilio.Http;
using Twilio.Readers.Api.V2010.Account;
using Twilio.Updaters.Api.V2010.Account;

namespace Twilio.Rest.Api.V2010.Account {

    public class Key : SidResource {
        /**
         * fetch
         * 
         * @param accountSid The account_sid
         * @param sid The sid
         * @return KeyFetcher capable of executing the fetch
         */
        public static KeyFetcher Fetch(string accountSid, string sid) {
            return new KeyFetcher(accountSid, sid);
        }
    
        /**
         * Create a KeyFetcher to execute fetch.
         * 
         * @param sid The sid
         * @return KeyFetcher capable of executing the fetch
         */
        public static KeyFetcher Fetch(string sid) {
            return new KeyFetcher(sid);
        }
    
        /**
         * update
         * 
         * @param accountSid The account_sid
         * @param sid The sid
         * @return KeyUpdater capable of executing the update
         */
        public static KeyUpdater Update(string accountSid, string sid) {
            return new KeyUpdater(accountSid, sid);
        }
    
        /**
         * Create a KeyUpdater to execute update.
         * 
         * @param sid The sid
         * @return KeyUpdater capable of executing the update
         */
        public static KeyUpdater Update(string sid) {
            return new KeyUpdater(sid);
        }
    
        /**
         * delete
         * 
         * @param accountSid The account_sid
         * @param sid The sid
         * @return KeyDeleter capable of executing the delete
         */
        public static KeyDeleter Delete(string accountSid, string sid) {
            return new KeyDeleter(accountSid, sid);
        }
    
        /**
         * Create a KeyDeleter to execute delete.
         * 
         * @param sid The sid
         * @return KeyDeleter capable of executing the delete
         */
        public static KeyDeleter Delete(string sid) {
            return new KeyDeleter(sid);
        }
    
        /**
         * read
         * 
         * @param accountSid The account_sid
         * @return KeyReader capable of executing the read
         */
        public static KeyReader Read(string accountSid) {
            return new KeyReader(accountSid);
        }
    
        /**
         * Create a KeyReader to execute read.
         * 
         * @return KeyReader capable of executing the read
         */
        public static KeyReader Read() {
            return new KeyReader();
        }
    
        /**
         * Converts a JSON string into a Key object
         * 
         * @param json Raw JSON string
         * @return Key object represented by the provided JSON
         */
        public static Key FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<Key>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("sid")]
        private readonly string sid;
        [JsonProperty("friendly_name")]
        private readonly string friendlyName;
        [JsonProperty("date_created")]
        private readonly DateTime? dateCreated;
        [JsonProperty("date_updated")]
        private readonly DateTime? dateUpdated;
    
        public Key() {
        
        }
    
        private Key([JsonProperty("sid")]
                    string sid, 
                    [JsonProperty("friendly_name")]
                    string friendlyName, 
                    [JsonProperty("date_created")]
                    string dateCreated, 
                    [JsonProperty("date_updated")]
                    string dateUpdated) {
            this.sid = sid;
            this.friendlyName = friendlyName;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
        }
    
        /**
         * @return The sid
         */
        public override string GetSid() {
            return this.sid;
        }
    
        /**
         * @return The friendly_name
         */
        public string GetFriendlyName() {
            return this.friendlyName;
        }
    
        /**
         * @return The date_created
         */
        public DateTime? GetDateCreated() {
            return this.dateCreated;
        }
    
        /**
         * @return The date_updated
         */
        public DateTime? GetDateUpdated() {
            return this.dateUpdated;
        }
    }
}