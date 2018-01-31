

function currentTime(){
  var d = new Date();
  var day = d.getDate();
  var month = (d.getMonth() + 1);
  var year = d.getFullYear();
  console.log(month + "/" + day + "/" + year);
}

function isLeapYear(year){

  if (year % 100 == 0 && year % 400 != 0) {
    console.log(year + " is not a leap year.");
  }
  else if (year % 4 == 0 || year % 400 == 0) {
    console.log(year + " is a leap year.");
  }
  else {
    console.log(year + " is not a leap year.");
  }
}


function isConsecutive(arr){
  var sequence, i;
  sequence = false;
  while (!sequence) {
    sequence = true;
    for (var i = 0; i < arr.length; i++) {
      if ((arr[i] + 1) == arr[i + 1]) {
        sequence = false;
      }
    }
  }
}

function duplicateNumbers(arr){

}

function returnFirstElements(arr) {
  var first = arr[0];
  console.log(first);
}

function arrayToString(arr){
  var string = "";
  for (var i = 0; i < array.length; i++) {
    string.concat(arr[i] + " ");
  }
  console.log(string);
}
