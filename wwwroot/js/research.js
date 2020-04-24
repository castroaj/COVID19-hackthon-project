


function openOptions()
{
    var button = document.getElementById('optionsButton')
    var option = document.getElementById('options')

    

    if (option.style.display == "none")
    {
        option.style.display = "block"
        button.innerHTML = '<h4>Close filtering options</h4>'
    }
    else
    {
        option.style.display = "none"
        button.innerHTML = '<h4>View filtering options</h4>'
    }
}

function openresult(index)
{
    var button = document.getElementById('result-' + index)
    var option = document.getElementById('result-body-' + index)
    var row = document.getElementById('row-' + index)

    

    if (option.style.display == "none")
    {
        option.style.display = "block"
        row.style.width = "100%";
        button.innerHTML = "Close Result"
    }
    else
    {
        option.style.display = "none"
        row.style.width = "100%";
        button.innerHTML = "Open Result"
    }
}