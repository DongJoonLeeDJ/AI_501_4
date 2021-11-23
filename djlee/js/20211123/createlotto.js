let numbers = [] //각 회차의 로또번호 추출할 때 쓰임
let mycount = -1 //몇 번째 div안에다가 로또번호 출력시킬지
let drwnumbers = [] //중복된 회차 찾는 용도
//색깔 배열
let lotto_colors= ['yellow', 'blue', 'red', 'gray', 'green']

//로또 생성 함수
function createLottoNum(drwnum){
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
    //textbox(회차정보입력하는 것)
    let drwNum = document.querySelector('#drwNum')

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