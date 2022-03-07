from konlpy.tag import Okt

okt = Okt()
result = okt.morphs('와 이런 것도 영화라고 차라리 뮤직비디오를 만드는 게 나을 뻔', stem = True)
print(result)

# conda install konlpy