let numbers = [] //각 회차의 로또번호 추출할 때 쓰임
let mycount = -1 //몇 번째 div안에다가 로또번호 출력시킬지
let drwnumbers = [] //중복된 회차 찾는 용도(회차들 정보 저장하는 배열)
//색깔 배열
let lotto_colors= ['yellow', 'blue', 'red', 'gray', 'green']

//로또 생성 함수
function createLottoNum(drwnum){
    if( isNaN(drwnum) )
    {
        alert("이건 숫자가 아닙니다.")
        return
    }
    if(drwnum.value == '')
    {
        alert('공백')
        return
    }
    for(let item of drwnumbers)
    {
        if(item == drwnum)
        {
            alert("중복된 회차")
            return
        }
    }

    for(let i = 0; i<7; i++)
    {
        let mynum = Math.floor(Math.random()*45)+1
        if(i>0) //하나라도 데이터 있다면 중복체크
        {
            if(numbers.indexOf(mynum) != -1)
            {
                i--
                continue //i를 깎고 continue하므로 
            }            //다시 원래의 i번째 수행가능
        }
        numbers.push(mynum)
    }
    let temp = new lotto(drwnum, 
        numbers[0],numbers[1],numbers[2],numbers[3],
        numbers[4],numbers[5],numbers[6])
    lottos.push(temp)
    numbers=[] //numbers 배열 초기화
    drwnumbers.push(drwnum)//drwnum: 회차정보
    mycount++ //로또 생성 횟수

}
//배경색깔 세팅
function setBackgroundColor(num){
}
//글자색깔 세팅
function setfontColor(num){
}

//function(){}  이거랑
//()=>{} 이 코드가 서로 같은 거
window.onload = () => {
    //로또 생성 버튼
    let start_lotto = document.querySelector
                        ('#create_lotto')
    
    let drwNum = document.querySelector('#drwNum')
                        //()=>{}
    //function(){}
    start_lotto.onclick = () => {
        createLottoNum(drwNum.value)
        let mylottos
        switch (mycount%3) {
            case 0:
                //id가 one인 태그의 자손들인데 
                //클래스명이 one인 태그들
                mylottos = document.querySelectorAll
                                ('#one>.one')
                break;
            case 1:
                mylottos = document.querySelectorAll
                                ('#two>.two')
                break;
            case 2:
                mylottos = document.querySelectorAll
                                ('#three>.three')
                break;
                    default:
                break;
        }
        
        mylottos[0].innerText = lottos[mycount].drwNo+"회차 :"
        mylottos[1].innerText = lottos[mycount].one
        mylottos[2].innerText = lottos[mycount].two
        mylottos[3].innerText = lottos[mycount].three
        mylottos[4].innerText = lottos[mycount].four
        mylottos[5].innerText = lottos[mycount].five
        mylottos[6].innerText = lottos[mycount].six
        mylottos[7].innerText = lottos[mycount].bns
    }
    //textbox(회차정보입력하는 것)

    let all_random = document.querySelector
                         ('#all_random')
    let case_by_case_random = document.querySelector
                                ('#case_by_case_random')

    let same_color = document.querySelector('#same_color')
    let number_by_number = document.querySelector
                            ('#number_by_number')
    let black_and_white = document.querySelector
                            ('#black_and_white')


}