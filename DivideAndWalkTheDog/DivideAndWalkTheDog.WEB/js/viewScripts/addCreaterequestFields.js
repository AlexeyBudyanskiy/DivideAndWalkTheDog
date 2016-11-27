var userCanCounter = 1;
var userNeedCounter = 1;
var tempIdCounter = 1;

var canCandidates = [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15];
var needCandidates = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15];

function addUserCanWalkField() {
    if (userCanCounter < 14) {
        var position = canCandidates[0];
        canCandidates.shift();

        var htmlString = "<div class=\"row\" id=\"userCreateRequestField"+tempIdCounter+"\">";
        htmlString += "<div class=\"col m4\">";
        htmlString += "<label>Day of week</label>";
        htmlString += "<div class=\"input-field col s12\">";
        htmlString += "<select ng-model=\"canDayTimes["+ position +"].Day\">"
        htmlString += "<option value=\"\" disabled selected>Day</option>"
        htmlString += "<option value=\"7\">Sunday</option>";
        htmlString += "<option value=\"1\">Monday</option>";
        htmlString += "<option value=\"2\">Tuesday</option>";
        htmlString += "<option value=\"3\">Wednesday</option>";
        htmlString += "<option value=\"4\">Thursday</option>"
        htmlString += "<option value=\"5\">Friday</option>";
        htmlString += "<option value=\"6\">Saturday</option>";
        htmlString += "</select>";
        htmlString += "</div>";
        htmlString += "</div>";
        htmlString += "<div class=\"col m4\">";
        htmlString += "<label>From</label>";
        htmlString += "<div class=\"input-field col s12\">";
        htmlString += "<input type=\"time\" name=\"time\" placeholder=\"hh:mm\" class=\"ng-not-empty ng-dirty ng-invalid ng-invalid-time ng-touched\" ng-model=\"canDayTimes["+position+"].DayTimeStart\" />";
        htmlString += "</div>";
        htmlString += "</div>";
        htmlString += "<div class=\"col m4\">";
        htmlString += "<label>To</label>";
        htmlString += "<div class=\"input-field col s12\">";
        htmlString += "<input type=\"time\" name=\"time\" placeholder=\"hh:mm\" ng-model=\"canDayTimes["+position+"].DayTimeFinish\" />";
        htmlString += "</div>";
        htmlString += "</div>";
        htmlString += "<div class=\"center grey-text pointer\" onclick=\"removeUserCanWalkField(" + tempIdCounter + ")\"><span><i class=\"material-icons\">remove</i></span></div>"
        htmlString += "<input type=\"hidden\" value=\"" + position +"\" id=\"positionNumber"+ tempIdCounter+"\"> "
        htmlString += "</div>";

        tempIdCounter++;
        userCanCounter++;
        $("#userCanWalkSeparator").before(htmlString);
        $('select').material_select();
    }
}

function addUserNeedWalkField() {
    if (userNeedCounter < 14) {
        
        var position = needCandidates[0];
        needCandidates.shift();

        var htmlString = "<div class=\"row\" id=\"userCreateRequestField"+tempIdCounter+"\">";
        htmlString += "<div class=\"col m4\">";
        htmlString += "<label>Day of week</label>";
        htmlString += "<div class=\"input-field col s12\">";
        htmlString += "<select ng-model=\"needDayTimes["+ position +"].Day\">"
        htmlString += "<option value=\"\" disabled selected>Day</option>"
        htmlString += "<option value=\"7\">Sunday</option>";
        htmlString += "<option value=\"1\">Monday</option>";
        htmlString += "<option value=\"2\">Tuesday</option>";
        htmlString += "<option value=\"3\">Wednesday</option>";
        htmlString += "<option value=\"4\">Thursday</option>"
        htmlString += "<option value=\"5\">Friday</option>";
        htmlString += "<option value=\"6\">Saturday</option>";
        htmlString += "</select>";
        htmlString += "</div>";
        htmlString += "</div>";
        htmlString += "<div class=\"col m4\">";
        htmlString += "<label>From</label>";
        htmlString += "<div class=\"input-field col s12\">";
        htmlString += "<input type=\"time\" name=\"time\" placeholder=\"hh:mm\" ng-model=\"needDayTimes["+position+"].DayTimeStart\" />";
        htmlString += "</div>";
        htmlString += "</div>";
        htmlString += "<div class=\"col m4\">";
        htmlString += "<label>To</label>";
        htmlString += "<div class=\"input-field col s12\">";
        htmlString += "<input type=\"time\" name=\"time\" placeholder=\"hh:mm\" ng-model=\"needDayTimes["+position+"].DayTimeFinish\" />";
        htmlString += "</div>";
        htmlString += "</div>";
        htmlString += "<div class=\"center grey-text pointer\" onclick=\"removeUserNeedWalkField(" + tempIdCounter + ")\"><span><i class=\"material-icons\">remove</i></span></div>"
        htmlString += "<input type=\"hidden\" value=\"" + position +"\" id=\"positionNumber"+ tempIdCounter+"\"> "
        htmlString += "</div>";

        tempIdCounter++;
        userNeedCounter++;
        $("#userNeedWalkSeparator").before(htmlString);
        $('select').material_select();
    }
}

function removeUserCanWalkField(number) {
    var id = "#positionNumber" + number;
    var positionNumber = $(id).val();
    canCandidates.push(+positionNumber);
    canCandidates.sort(compareNumeric);
    id = "#userCreateRequestField" + number;
    $(id).remove();
    userCanCounter--;
}

function removeUserNeedWalkField(number) {
    var id = "#positionNumber" + number;
    var positionNumber = $(id).val();
    needCandidates.push(+positionNumber);
    needCandidates.sort(compareNumeric);

    id = "userCreateRequestField" + number;
    $("#" + id).remove();
    userNeedCounter--;
}

function compareNumeric(a, b) {
  if (a > b) return 1;
  if (a < b) return -1;
}


        
