const submit = document.getElementById('submit');
/*
*   Creating an event listener and setting variables to create the functionality of creating new HTML rows and Cells and filling them with
*   user input data.
*/
submit.addEventListener('click', function(){
    // User input variables
    var name = document.getElementById('name');
    var amount = document.getElementById('date');
    var date = document.getElementById('amount');
    var table = document.getElementById('table');
    // Creating the HTML rows and cells, then appending them to the table with the user input data.
    var newRow = table.insertRow(-1);
    var newCell0 = newRow.insertCell(0);
    var newCell1 = newRow.insertCell(1);
    var newCell2 = newRow.insertCell(2);
    var removeCell = newRow.insertCell(3);
    var text0 = document.createTextNode(name.value);
    newCell0.appendChild(text0);
    var text1 = document.createTextNode(date.value);
    newCell1.appendChild(text1);
    var text2 = document.createTextNode(amount.value);
    newCell2.appendChild(text2);
    var btn = document.createElement('button');
    btn.innerHTML = "Remove";
    removeCell.appendChild(btn);

    // Remove button event listener.
    btn.addEventListener('click', function(){
        newCell0.remove();
        newCell1.remove();
        newCell2.remove();
        removeCell.remove();
    });

    // Clears all input fields after submit button is pressed.
    name.value = '';
    date.value = '';
    amount.value = '';
});