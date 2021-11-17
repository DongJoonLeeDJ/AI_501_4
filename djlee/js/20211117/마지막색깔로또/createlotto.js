let numbers = []
let mycount = -1
let drwnumbers = []
let lotto_colors = ['yellow', 'blue', 'red', 'gray', 'green']

function createLottoNum(drwnum)
{
    for(let item of drwnumbers)
    {
        if(item == drwnum)
        {
            alert("중복된 회차")
            return
        }
    }

    for(let i = 0; i<7; i++ )
    {
        let mynum = Math.floor(Math.random()*45)+1
        if(i>0)
        {
            if(numbers.indexOf(mynum) != -1)
            {
                i--
                continue
            }   
        }
        numbers.push(mynum)
    }
    lottos.push(new lotto(drwnum,numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7]))
    numbers = []
    drwnumbers.push(drwnum)
    mycount++
}

function setBackgroundColor(num)
{
    let mynum = Number(num)
    if(mynum<=10)
        return 'yellow'
    else if(mynum<=20)
        return 'blue'
    else if(mynum<=30)
        return 'red'
    else if(mynum<=40)
        return 'gray'
    else
        return 'green'
}
function setfontColor(num)
{
    let mynum = Number(num)
    if(mynum >= 11 && mynum <=30)
        return 'white'
    return 'black'
}


window.onload = function()
{
    let start_lotto = document.querySelector('#create_lotto')
    let drwNum = document.querySelector('#drwNum')
    let mylottos
    start_lotto.onclick = function(){

        if(drwNum.value == '')
        {
            alert('공백')
            return
        }

        createLottoNum(drwNum.value)
        switch (mycount%3) {
            case 0:
                mylottos = document.querySelectorAll('#one>.one')
                mylottos[0].innerText = lottos[mycount].drwNo + "회차 : " 
                mylottos[1].innerText = lottos[mycount].one
                mylottos[2].innerText = lottos[mycount].two
                mylottos[3].innerText = lottos[mycount].three
                mylottos[4].innerText = lottos[mycount].four
                mylottos[5].innerText = lottos[mycount].five
                mylottos[6].innerText = lottos[mycount].six
                mylottos[7].innerText = lottos[mycount].bns
                
                break;
            case 1:
                mylottos = document.querySelectorAll('#two>.two')
                mylottos[0].innerText = lottos[mycount].drwNo + "회차 : " 
                mylottos[1].innerText = lottos[mycount].one
                mylottos[2].innerText = lottos[mycount].two
                mylottos[3].innerText = lottos[mycount].three
                mylottos[4].innerText = lottos[mycount].four
                mylottos[5].innerText = lottos[mycount].five
                mylottos[6].innerText = lottos[mycount].six
                mylottos[7].innerText = lottos[mycount].bns
                
                break;  
            case 2:
                mylottos = document.querySelectorAll('#three>.three')
                mylottos[0].innerText = lottos[mycount].drwNo + "회차 : " 
                mylottos[1].innerText = lottos[mycount].one
                mylottos[2].innerText = lottos[mycount].two
                mylottos[3].innerText = lottos[mycount].three
                mylottos[4].innerText = lottos[mycount].four
                mylottos[5].innerText = lottos[mycount].five
                mylottos[6].innerText = lottos[mycount].six
                mylottos[7].innerText = lottos[mycount].bns
                
                break;      
            default:
                break;
        }

    }

    let all_random = document.querySelector("#all_random")
    all_random.onclick = function()
    {
        for(let i = 1; i<8; i++)
        {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = lotto_colors[Math.floor(Math.random()*5)]
        }
        for(let i = 1; i<8; i++)
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = lotto_colors[Math.floor(Math.random()*5)]
        for(let i = 1; i<8; i++)
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = lotto_colors[Math.floor(Math.random()*5)]
    }

    let case_by_case_random = document.querySelector("#case_by_case_random")
    case_by_case_random.onclick = function()
    {
        let temp_my_color = lotto_colors[Math.floor(Math.random()*5)]
        for(let i = 1; i<8; i++)
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = temp_my_color
        temp_my_color = lotto_colors[Math.floor(Math.random()*5)]
        for(let i = 1; i<8; i++)
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = temp_my_color
        temp_my_color = lotto_colors[Math.floor(Math.random()*5)]
        for(let i = 1; i<8; i++)
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = temp_my_color
    }

    let same_color = document.querySelector('#same_color')
    same_color.onclick = function()
    {   
        let temp_my_color = `rgb(${Math.floor(Math.random()*256)},${Math.floor(Math.random()*256)},${Math.floor(Math.random()*256)})`
        for(let i = 1; i<8; i++)
        {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = temp_my_color
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = temp_my_color
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = temp_my_color
        }
    }

    let number_by_number = document.querySelector('#number_by_number')
    number_by_number.onclick = function()
    {        
        for(let i = 1; i<8; i++)
        {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#one>.one')[i].innerText)
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#two>.two')[i].innerText)
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#three>.three')[i].innerText)
        }
    }

    let black_and_white = document.querySelector('#black_and_white')
    black_and_white.onclick = function()
    {
        for(let i = 1; i<8; i++)
        {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#one>.one')[i].innerText)
            document.querySelectorAll('#one>.one')[i].style.color = setfontColor(document.querySelectorAll('#one>.one')[i].innerText)
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#two>.two')[i].innerText)
            document.querySelectorAll('#two>.two')[i].style.color = setfontColor(document.querySelectorAll('#two>.two')[i].innerText)
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#three>.three')[i].innerText)
            document.querySelectorAll('#three>.three')[i].style.color = setfontColor(document.querySelectorAll('#three>.three')[i].innerText)
        }
    }

}