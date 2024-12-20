using Flarum.Api;
using Flarum.Api.ApiContracts;
using Flarum.Api.Bases;
using Flarum.Api.Bases.ModelBases;
using Flarum.Api.Models.ResponseModel;
using Flarum.Provider.Mappers;
using Flarum.Provider.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Provider
{
    public class FlarumProvider
    {
        public FlarumApiHandlerOption Option { get; set; } = new FlarumApiHandlerOption();
        public FlarumApiHandler Handler { get; } = new FlarumApiHandler();

        private string Token { get; set; }

        #region Request Methods
        public async Task<Results<TResponse, ErrorResultBase>> RequestAsync<TRequest, TResponse, TError, TActualRequest>(
        ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract)
        where TError : ErrorResultBase
        where TActualRequest : ActualRequestBase
        where TRequest : RequestBase
        where TResponse : ResponseBase, new()
        {
            try
            {
                return await Handler.RequestAsync(contract, Option);
            }
            catch (Exception ex)
            {
                return Results<TResponse, ErrorResultBase>.CreateError(new ExceptionedErrorBase(-500, ex.Message, ex));
            }
        }

        public async Task<Results<TResponse, ErrorResultBase>> RequestAsync<TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, TRequest request)
            where TError : ErrorResultBase
            where TActualRequest : ActualRequestBase
            where TRequest : RequestBase
            where TResponse : ResponseBase, new()
        {
            try
            {
                return await Handler.RequestAsync(contract, request, Option);
            }
            catch (Exception ex)
            {
                return Results<TResponse, ErrorResultBase>.CreateError(new ExceptionedErrorBase(-500, ex.Message, ex));
            }
        }

        public async Task<Results<TCustomResponse, ErrorResultBase>> RequestAsync<
            TCustomResponse, TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, TRequest? request)
            where TError : ErrorResultBase
            where TActualRequest : ActualRequestBase
            where TRequest : RequestBase
            where TResponse : ResponseBase, new()
            where TCustomResponse : ResponseBase, new()
        {
            try
            {
                return await Handler.RequestAsync<TCustomResponse, TRequest, TResponse, TError, TActualRequest>(
                    contract, request, Option);
            }
            catch (Exception ex)
            {
                return Results<TCustomResponse, ErrorResultBase>.CreateError(
                    new ExceptionedErrorBase(-500, ex.Message, ex));
            }
        }

        public async Task<Results<TCustomResponse, ErrorResultBase>> RequestAsync<
            TCustomRequest, TCustomResponse, TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, bool differ, TCustomRequest? request)
            where TError : ErrorResultBase
            where TActualRequest : ActualRequestBase
            where TRequest : RequestBase
            where TResponse : ResponseBase, new()
            where TCustomResponse : ResponseBase, new()
        {
            try
            {
                return await Handler
                    .RequestAsync<TCustomRequest, TCustomResponse, TRequest, TResponse, TError, TActualRequest>(
                        contract, true, request, Option);
            }
            catch (Exception ex)
            {
                return Results<TCustomResponse, ErrorResultBase>.CreateError(
                    new ExceptionedErrorBase(-500, ex.Message, ex));
            }
        }

        public async Task<Results<TResponse, ErrorResultBase>> RequestAsync<TCustomRequest, TRequest, TResponse, TError,
                                                                            TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, bool differ, TCustomRequest? request,
            FlarumApiHandlerOption option)
            where TError : ErrorResultBase
            where TActualRequest : ActualRequestBase
            where TRequest : RequestBase
            where TResponse : ResponseBase, new()
        {
            try
            {
                return await Handler.RequestAsync(
                    contract, true, request, option);
            }
            catch (Exception ex)
            {
                return Results<TResponse, ErrorResultBase>.CreateError(
                    new ExceptionedErrorBase(-500, ex.Message, ex));
            }
        }
        #endregion

        public async Task<FlarumUser> GetFlarumUserByIdAsync(int id)
        {
            var request = new GetUserInfoRequest() { UserId = id };
            var result = await RequestAsync<GetUserInfoRequest, GetUserInfoResponse, ErrorResultBase, GetUserInfoActualRequest>(new GetUserInfoApi(), new GetUserInfoRequest() { UserId = 58 });
            return UserDataToFlarumUserMapper.MapToFlarumUser(
                    result.Match(
                        success => success?.Data.User,
                        error => new()));
        }
    }
}
