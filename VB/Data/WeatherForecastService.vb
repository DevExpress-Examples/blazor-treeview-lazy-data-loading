Namespace DataMappings.Data

    Public Class WeatherForecastService

        Private Shared ReadOnly Summaries As String() = {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"}

        Public Function GetForecastAsync(ByVal startDate As DateTime) As Task(Of WeatherForecast())
            Dim rng = New Random()
            Return Task.FromResult(Enumerable.Range(1, 5).[Select](Function(index) New WeatherForecast With {.[Date] = startDate.AddDays(index), .TemperatureC = rng.[Next](-20, 55), .Summary = Summaries(rng.[Next](Summaries.Length))}).ToArray())
        End Function
    End Class
End Namespace
