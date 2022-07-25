/*
*   Event Listener that will Take text from input field when 'submit
*   task' button is pressed. and add it to the 'ul' list
*
*/
submit.addEventListener('click', function(){
    // Adding tasks to list
    const input = document.getElementById('inputField');
    const ul = document.getElementById("list");
    const li = document.createElement("li");
    li.innerHTML = input.value;
    ul.appendChild(li);
    // Remove user input when submit is pressed.
    input.value = '';

    // Remove task button
    const btn = document.createElement('button');
    btn.innerHTML = "Remove";
    li.appendChild(btn);

    // When 'remove task' button is clicked it removes a task
    btn.addEventListener('click', function(){
        btn.parentNode.removeChild(btn);
        li.parentNode.removeChild(li);
    });
    
    
    
});
