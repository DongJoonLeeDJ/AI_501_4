// $(function(){}) 
//화면에 다 불러와 진 뒤에 함수 실행
//$().ready(function(){})//이거랑 동일한 거

$(
    function()
    {
       const sounds = $('audio')
       const pads = $(".pads div")
       const visual = $('.visual')
       const title = $('.title')
       const colors = ['red', 'orange', 'yellow','green',
                        'blue','plum']

        //음악 재생 끝났을 때 이벤트
        //js의 forEach
        sounds.each(function(index, soundFile)
        {
            soundFile.onended = function() {
                visual.text('')
                title.text('')
            }
        })

        pads.each ( function(index, pad) {
            $(pad).on('click', function() {
                sounds.each(function(index, soundFile){
                    soundFile.pause()
                })
                //내가 클릭한 부분의 사운드
                //ex)가장 첫번째꺼 클릭하면
                //1.mp3 재생
                if(sounds[index]){
                    sounds[index].currentTime = 0
                    sounds[index].play()
                    //audio태그의 src속성의 문자열을 sound/로 짜름
                    const strArray = 
                    sounds[index].src.split("sound/")
                    title.text(strArray[1])//1.mp3, 2.mp3등의 제목 찍힘
                }

                //index는 pads안에서 몇 번째 div냐...
                createBubbles(index)
            });

        })

        const createBubbles = function(index)
        {
            visual.text('')
            const bubble = $('<div></div>')
            visual.append(bubble) //visual에 bubble삽입
            bubble.css('background', colors[index]).
            css('top','300px').
            css('animation', 
            'animation 2000ms linear infinite both')
        }

    }
)