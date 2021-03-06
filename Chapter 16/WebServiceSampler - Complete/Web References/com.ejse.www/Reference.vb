﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.510
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.510.
'
Namespace com.ejse.www
    
    '<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ServiceSoap", [Namespace]:="http://ejse.com/WeatherService/")>  _
    Public Class Service
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://www.ejse.com/WeatherService/Service.asmx"
        End Sub
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ejse.com/WeatherService/GetIraqWeatherInfo", RequestNamespace:="http://ejse.com/WeatherService/", ResponseNamespace:="http://ejse.com/WeatherService/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetIraqWeatherInfo(ByVal city As IraqCities) As WeatherInfo
            Dim results() As Object = Me.Invoke("GetIraqWeatherInfo", New Object() {city})
            Return CType(results(0),WeatherInfo)
        End Function
        
        '<remarks/>
        Public Function BeginGetIraqWeatherInfo(ByVal city As IraqCities, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetIraqWeatherInfo", New Object() {city}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetIraqWeatherInfo(ByVal asyncResult As System.IAsyncResult) As WeatherInfo
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),WeatherInfo)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ejse.com/WeatherService/GetIraqExtendedWeatherInfo", RequestNamespace:="http://ejse.com/WeatherService/", ResponseNamespace:="http://ejse.com/WeatherService/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetIraqExtendedWeatherInfo(ByVal city As IraqCities) As ExtendedWeatherInfo
            Dim results() As Object = Me.Invoke("GetIraqExtendedWeatherInfo", New Object() {city})
            Return CType(results(0),ExtendedWeatherInfo)
        End Function
        
        '<remarks/>
        Public Function BeginGetIraqExtendedWeatherInfo(ByVal city As IraqCities, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetIraqExtendedWeatherInfo", New Object() {city}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetIraqExtendedWeatherInfo(ByVal asyncResult As System.IAsyncResult) As ExtendedWeatherInfo
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),ExtendedWeatherInfo)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ejse.com/WeatherService/GetWeatherInfo", RequestNamespace:="http://ejse.com/WeatherService/", ResponseNamespace:="http://ejse.com/WeatherService/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetWeatherInfo(ByVal zipCode As Integer) As WeatherInfo
            Dim results() As Object = Me.Invoke("GetWeatherInfo", New Object() {zipCode})
            Return CType(results(0),WeatherInfo)
        End Function
        
        '<remarks/>
        Public Function BeginGetWeatherInfo(ByVal zipCode As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetWeatherInfo", New Object() {zipCode}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetWeatherInfo(ByVal asyncResult As System.IAsyncResult) As WeatherInfo
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),WeatherInfo)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ejse.com/WeatherService/GetExtendedWeatherInfo", RequestNamespace:="http://ejse.com/WeatherService/", ResponseNamespace:="http://ejse.com/WeatherService/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetExtendedWeatherInfo(ByVal zipCode As Integer) As ExtendedWeatherInfo
            Dim results() As Object = Me.Invoke("GetExtendedWeatherInfo", New Object() {zipCode})
            Return CType(results(0),ExtendedWeatherInfo)
        End Function
        
        '<remarks/>
        Public Function BeginGetExtendedWeatherInfo(ByVal zipCode As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetExtendedWeatherInfo", New Object() {zipCode}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetExtendedWeatherInfo(ByVal asyncResult As System.IAsyncResult) As ExtendedWeatherInfo
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),ExtendedWeatherInfo)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ejse.com/WeatherService/GetDayForecastInfo", RequestNamespace:="http://ejse.com/WeatherService/", ResponseNamespace:="http://ejse.com/WeatherService/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetDayForecastInfo(ByVal day As ForecastDays, ByVal zipCode As Integer) As DayForecastInfo
            Dim results() As Object = Me.Invoke("GetDayForecastInfo", New Object() {day, zipCode})
            Return CType(results(0),DayForecastInfo)
        End Function
        
        '<remarks/>
        Public Function BeginGetDayForecastInfo(ByVal day As ForecastDays, ByVal zipCode As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetDayForecastInfo", New Object() {day, zipCode}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetDayForecastInfo(ByVal asyncResult As System.IAsyncResult) As DayForecastInfo
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),DayForecastInfo)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ejse.com/WeatherService/GetNineDayForecastInfo", RequestNamespace:="http://ejse.com/WeatherService/", ResponseNamespace:="http://ejse.com/WeatherService/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetNineDayForecastInfo(ByVal zipCode As Integer) As NineDayForecastInfo
            Dim results() As Object = Me.Invoke("GetNineDayForecastInfo", New Object() {zipCode})
            Return CType(results(0),NineDayForecastInfo)
        End Function
        
        '<remarks/>
        Public Function BeginGetNineDayForecastInfo(ByVal zipCode As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetNineDayForecastInfo", New Object() {zipCode}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetNineDayForecastInfo(ByVal asyncResult As System.IAsyncResult) As NineDayForecastInfo
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),NineDayForecastInfo)
        End Function
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ejse.com/WeatherService/")>  _
    Public Enum IraqCities
        
        '<remarks/>
        AlAzamiyah
        
        '<remarks/>
        AlBasrah
        
        '<remarks/>
        AlHillah
        
        '<remarks/>
        AlKarkh
        
        '<remarks/>
        AlKazimiyah
        
        '<remarks/>
        AlKut
        
        '<remarks/>
        AnNasiriyah
        
        '<remarks/>
        Baghdad
        
        '<remarks/>
        Baqubah
        
        '<remarks/>
        Mosul
        
        '<remarks/>
        Nineveh
        
        '<remarks/>
        TallKayf
        
        '<remarks/>
        Najaf
    End Enum
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ejse.com/WeatherService/")>  _
    Public Class WeatherInfo
        
        '<remarks/>
        Public Location As String
        
        '<remarks/>
        Public IconIndex As Integer
        
        '<remarks/>
        Public Temprature As String
        
        '<remarks/>
        Public FeelsLike As String
        
        '<remarks/>
        Public Forecast As String
        
        '<remarks/>
        Public Visibility As String
        
        '<remarks/>
        Public Pressure As String
        
        '<remarks/>
        Public DewPoint As String
        
        '<remarks/>
        Public UVIndex As String
        
        '<remarks/>
        Public Humidity As String
        
        '<remarks/>
        Public Wind As String
        
        '<remarks/>
        Public ReportedAt As String
        
        '<remarks/>
        Public LastUpdated As String
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ejse.com/WeatherService/")>  _
    Public Class NineDayForecastInfo
        
        '<remarks/>
        Public Day1 As DayForecastInfo
        
        '<remarks/>
        Public Day2 As DayForecastInfo
        
        '<remarks/>
        Public Day3 As DayForecastInfo
        
        '<remarks/>
        Public Day4 As DayForecastInfo
        
        '<remarks/>
        Public Day5 As DayForecastInfo
        
        '<remarks/>
        Public Day6 As DayForecastInfo
        
        '<remarks/>
        Public Day7 As DayForecastInfo
        
        '<remarks/>
        Public Day8 As DayForecastInfo
        
        '<remarks/>
        Public Day9 As DayForecastInfo
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ejse.com/WeatherService/")>  _
    Public Class DayForecastInfo
        
        '<remarks/>
        Public Day As String
        
        '<remarks/>
        Public [Date] As String
        
        '<remarks/>
        Public IconIndex As Integer
        
        '<remarks/>
        Public Forecast As String
        
        '<remarks/>
        Public High As String
        
        '<remarks/>
        Public Low As String
        
        '<remarks/>
        Public PrecipChance As String
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ejse.com/WeatherService/")>  _
    Public Class ExtendedWeatherInfo
        
        '<remarks/>
        Public Info As WeatherInfo
        
        '<remarks/>
        Public Day1 As DayForecastInfo
        
        '<remarks/>
        Public Day2 As DayForecastInfo
        
        '<remarks/>
        Public Day3 As DayForecastInfo
        
        '<remarks/>
        Public Day4 As DayForecastInfo
        
        '<remarks/>
        Public Day5 As DayForecastInfo
        
        '<remarks/>
        Public Day6 As DayForecastInfo
        
        '<remarks/>
        Public Day7 As DayForecastInfo
        
        '<remarks/>
        Public Day8 As DayForecastInfo
        
        '<remarks/>
        Public Day9 As DayForecastInfo
    End Class
    
    '<remarks/>
    <System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ejse.com/WeatherService/")>  _
    Public Enum ForecastDays
        
        '<remarks/>
        Day1
        
        '<remarks/>
        Day2
        
        '<remarks/>
        Day3
        
        '<remarks/>
        Day4
        
        '<remarks/>
        Day5
        
        '<remarks/>
        Day6
        
        '<remarks/>
        Day7
        
        '<remarks/>
        Day8
        
        '<remarks/>
        Day9
    End Enum
End Namespace
