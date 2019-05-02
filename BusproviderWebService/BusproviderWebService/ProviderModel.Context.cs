﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusproviderWebService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProvidersWS_DBEntities : DbContext
    {
        public ProvidersWS_DBEntities()
            : base("name=ProvidersWS_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BusDetail> BusDetails { get; set; }
        public virtual DbSet<CityDetail> CityDetails { get; set; }
        public virtual DbSet<FeedbackDetail> FeedbackDetails { get; set; }
        public virtual DbSet<PassengerDetail> PassengerDetails { get; set; }
        public virtual DbSet<RouteDetail> RouteDetails { get; set; }
        public virtual DbSet<SeatBookingStatu> SeatBookingStatus { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TicketDetail> TicketDetails { get; set; }
    
        public virtual int AddRouteDetails(Nullable<int> busId, Nullable<int> sourceId, Nullable<int> destinationId, Nullable<System.DateTime> dateOfJourney, Nullable<double> price, Nullable<System.TimeSpan> arrivalTime, Nullable<System.TimeSpan> departureTime)
        {
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            var sourceIdParameter = sourceId.HasValue ?
                new ObjectParameter("sourceId", sourceId) :
                new ObjectParameter("sourceId", typeof(int));
    
            var destinationIdParameter = destinationId.HasValue ?
                new ObjectParameter("destinationId", destinationId) :
                new ObjectParameter("destinationId", typeof(int));
    
            var dateOfJourneyParameter = dateOfJourney.HasValue ?
                new ObjectParameter("dateOfJourney", dateOfJourney) :
                new ObjectParameter("dateOfJourney", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var arrivalTimeParameter = arrivalTime.HasValue ?
                new ObjectParameter("arrivalTime", arrivalTime) :
                new ObjectParameter("arrivalTime", typeof(System.TimeSpan));
    
            var departureTimeParameter = departureTime.HasValue ?
                new ObjectParameter("departureTime", departureTime) :
                new ObjectParameter("departureTime", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRouteDetails", busIdParameter, sourceIdParameter, destinationIdParameter, dateOfJourneyParameter, priceParameter, arrivalTimeParameter, departureTimeParameter);
        }
    
        public virtual ObjectResult<GetBusDetails_Result> GetBusDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBusDetails_Result>("GetBusDetails");
        }
    
        public virtual ObjectResult<GetCityDetails_Result> GetCityDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCityDetails_Result>("GetCityDetails");
        }
    
        public virtual int InsertBusDetails(string busNo, string busname, Nullable<int> capacity, string type)
        {
            var busNoParameter = busNo != null ?
                new ObjectParameter("busNo", busNo) :
                new ObjectParameter("busNo", typeof(string));
    
            var busnameParameter = busname != null ?
                new ObjectParameter("busname", busname) :
                new ObjectParameter("busname", typeof(string));
    
            var capacityParameter = capacity.HasValue ?
                new ObjectParameter("capacity", capacity) :
                new ObjectParameter("capacity", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBusDetails", busNoParameter, busnameParameter, capacityParameter, typeParameter);
        }
    
        public virtual int InsertCityDetails(string city, string state)
        {
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCityDetails", cityParameter, stateParameter);
        }
    
        public virtual int BookSeat(Nullable<int> seatNo, Nullable<int> busId, string status)
        {
            var seatNoParameter = seatNo.HasValue ?
                new ObjectParameter("seatNo", seatNo) :
                new ObjectParameter("seatNo", typeof(int));
    
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BookSeat", seatNoParameter, busIdParameter, statusParameter);
        }
    
        public virtual int ChangeSeatType(Nullable<int> seatNo, Nullable<int> busId, string seatType)
        {
            var seatNoParameter = seatNo.HasValue ?
                new ObjectParameter("seatNo", seatNo) :
                new ObjectParameter("seatNo", typeof(int));
    
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            var seatTypeParameter = seatType != null ?
                new ObjectParameter("seatType", seatType) :
                new ObjectParameter("seatType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeSeatType", seatNoParameter, busIdParameter, seatTypeParameter);
        }
    
        public virtual int DeleteBusRecord(Nullable<int> busId)
        {
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBusRecord", busIdParameter);
        }
    
        public virtual ObjectResult<GetBookingStatus_Result> GetBookingStatus(Nullable<int> busId)
        {
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBookingStatus_Result>("GetBookingStatus", busIdParameter);
        }
    
        public virtual int AddRouteDetails1(Nullable<int> busId, Nullable<int> sourceId, Nullable<int> destinationId, Nullable<System.DateTime> dateOfJourney, Nullable<double> price, Nullable<System.TimeSpan> arrivalTime, Nullable<System.TimeSpan> departureTime)
        {
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            var sourceIdParameter = sourceId.HasValue ?
                new ObjectParameter("sourceId", sourceId) :
                new ObjectParameter("sourceId", typeof(int));
    
            var destinationIdParameter = destinationId.HasValue ?
                new ObjectParameter("destinationId", destinationId) :
                new ObjectParameter("destinationId", typeof(int));
    
            var dateOfJourneyParameter = dateOfJourney.HasValue ?
                new ObjectParameter("dateOfJourney", dateOfJourney) :
                new ObjectParameter("dateOfJourney", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var arrivalTimeParameter = arrivalTime.HasValue ?
                new ObjectParameter("arrivalTime", arrivalTime) :
                new ObjectParameter("arrivalTime", typeof(System.TimeSpan));
    
            var departureTimeParameter = departureTime.HasValue ?
                new ObjectParameter("departureTime", departureTime) :
                new ObjectParameter("departureTime", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRouteDetails1", busIdParameter, sourceIdParameter, destinationIdParameter, dateOfJourneyParameter, priceParameter, arrivalTimeParameter, departureTimeParameter);
        }
    
        public virtual ObjectResult<GetRouteDetails_Result> GetRouteDetails(Nullable<int> sourceId, Nullable<int> destinationId, Nullable<System.DateTime> dateOfJourney)
        {
            var sourceIdParameter = sourceId.HasValue ?
                new ObjectParameter("sourceId", sourceId) :
                new ObjectParameter("sourceId", typeof(int));
    
            var destinationIdParameter = destinationId.HasValue ?
                new ObjectParameter("destinationId", destinationId) :
                new ObjectParameter("destinationId", typeof(int));
    
            var dateOfJourneyParameter = dateOfJourney.HasValue ?
                new ObjectParameter("dateOfJourney", dateOfJourney) :
                new ObjectParameter("dateOfJourney", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRouteDetails_Result>("GetRouteDetails", sourceIdParameter, destinationIdParameter, dateOfJourneyParameter);
        }
    
        public virtual ObjectResult<GetPassangerDetails_Result> GetPassangerDetails(Nullable<int> ticketId)
        {
            var ticketIdParameter = ticketId.HasValue ?
                new ObjectParameter("ticketId", ticketId) :
                new ObjectParameter("ticketId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPassangerDetails_Result>("GetPassangerDetails", ticketIdParameter);
        }
    }
}
