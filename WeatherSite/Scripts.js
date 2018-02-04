function getWeatherData(){
  var City = document.getElementById("FormCity").value;
  var State = document.getElementById("FormState").value;
  var whereText = City + ',' + State;
  console.log(whereText);

}
