using System.Collections.Generic;
using ConnectApp.Constants;
using ConnectApp.Models.Api;
using ConnectApp.Utils;
using Newtonsoft.Json;
using RSG;

namespace ConnectApp.Api {
    public static class LeaderBoardApi {
        public static Promise<FetchLeaderBoardCollectionResponse> FetchLeaderBoardCollection(int page) {
            var promise = new Promise<FetchLeaderBoardCollectionResponse>();
            var para = new Dictionary<string, object> {
                {"page", page}
            };
            var request = HttpManager.GET($"{Config.apiAddress}{Config.apiPath}/rankList/collection", parameter: para);
            HttpManager.resume(request: request).Then(responseText => {
                var collectionResponse =
                    JsonConvert.DeserializeObject<FetchLeaderBoardCollectionResponse>(value: responseText);
                promise.Resolve(value: collectionResponse);
            }).Catch(exception => promise.Reject(ex: exception));
            return promise;
        }

        public static Promise<FetchLeaderBoardColumnResponse> FetchLeaderBoardColumn(int page) {
            var promise = new Promise<FetchLeaderBoardColumnResponse>();
            var para = new Dictionary<string, object> {
                {"page", page}
            };
            var request = HttpManager.GET($"{Config.apiAddress}{Config.apiPath}/rankList/column", parameter: para);
            HttpManager.resume(request: request).Then(responseText => {
                var columnResponse = JsonConvert.DeserializeObject<FetchLeaderBoardColumnResponse>(value: responseText);
                promise.Resolve(value: columnResponse);
            }).Catch(exception => promise.Reject(ex: exception));
            return promise;
        }

        public static Promise<FetchBloggerResponse> FetchLeaderBoardBlogger(int page) {
            var promise = new Promise<FetchBloggerResponse>();
            var para = new Dictionary<string, object> {
                {"page", page}
            };
            var request = HttpManager.GET($"{Config.apiAddress}{Config.apiPath}/rankList/blogger", parameter: para);
            HttpManager.resume(request: request).Then(responseText => {
                var bloggerResponse = JsonConvert.DeserializeObject<FetchBloggerResponse>(value: responseText);
                promise.Resolve(value: bloggerResponse);
            }).Catch(exception => promise.Reject(ex: exception));
            return promise;
        }

        public static Promise<FetchBloggerResponse> FetchHomeBlogger(int page) {
            var promise = new Promise<FetchBloggerResponse>();
            var para = new Dictionary<string, object> {
                {"page", page}
            };
            var request = HttpManager.GET($"{Config.apiAddress}{Config.apiPath}/rankList/homeBlogger", parameter: para);
            HttpManager.resume(request: request).Then(responseText => {
                var homeBloggerResponse = JsonConvert.DeserializeObject<FetchBloggerResponse>(value: responseText);
                promise.Resolve(value: homeBloggerResponse);
            }).Catch(exception => promise.Reject(ex: exception));
            return promise;
        }

        public static Promise<FetchLeaderBoardCollectionDetailResponse> FetchLeaderBoardCollectionDetail(
            string collectionId, int page) {
            var promise = new Promise<FetchLeaderBoardCollectionDetailResponse>();
            var para = new Dictionary<string, object> {
                {"page", page}
            };
            var request = HttpManager.GET($"{Config.apiAddress}{Config.apiPath}/rankList/collection/{collectionId}",
                parameter: para);
            HttpManager.resume(request: request).Then(responseText => {
                var collectionDetailResponse =
                    JsonConvert.DeserializeObject<FetchLeaderBoardCollectionDetailResponse>(value: responseText);
                promise.Resolve(value: collectionDetailResponse);
            }).Catch(exception => promise.Reject(ex: exception));
            return promise;
        }

        public static Promise<FetchLeaderBoardColumnDetailResponse> FetchLeaderBoardColumnDetail(string columnId,
            int page) {
            var promise = new Promise<FetchLeaderBoardColumnDetailResponse>();
            var para = new Dictionary<string, object> {
                {"page", page}
            };
            var request = HttpManager.GET($"{Config.apiAddress}{Config.apiPath}/rankList/column/{columnId}",
                parameter: para);
            HttpManager.resume(request: request).Then(responseText => {
                var columnDetailResponse =
                    JsonConvert.DeserializeObject<FetchLeaderBoardColumnDetailResponse>(value: responseText);
                promise.Resolve(value: columnDetailResponse);
            }).Catch(exception => promise.Reject(ex: exception));
            return promise;
        }
    }
}