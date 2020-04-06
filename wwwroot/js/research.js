


function openOptions()
{
    var button = document.getElementById('optionsButton')
    var option = document.getElementById('options')

    

    if (option.style.display == "none")
    {
        option.style.display = "block"
        button.innerHTML = '<h2>Close filtering options</h2>'
    }
    else
    {
        option.style.display = "none"
        button.innerHTML = '<h2>View filtering options</h2>'
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
        row.style.width = "20%";
        button.innerHTML = "Open Result"
    }
}