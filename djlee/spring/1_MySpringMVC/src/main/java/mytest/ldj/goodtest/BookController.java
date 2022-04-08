package mytest.ldj.goodtest;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;


//@���� ������̼��� ���� : �����Ϸ����� ������ ����
//Override�� ������ �������̵��� �Ѵٴ� �ǹ�
//Depreciate�� ������ ������ �޼ҵ��� ���޽����� ���.


//MVC�� Control������ �Ѵ�.
@Controller
public class BookController {
	
	//BookService �������̽��� �����ϰ� �ִ� Ŭ������ �ڵ����� ����
	//��
	//BookService bookService = new BookServiceImpl();
	@Autowired
	BookService bookService;

	@RequestMapping(value="/create", method=RequestMethod.GET)
	public ModelAndView create() { //��� �� �޼ҵ��� �̸��� �߿����� �ʴ�. /create�� ���� �� �޼ҵ带 ȣ���ر� ����.
		return new ModelAndView("book/create");
	}
	
	//create�κ��� POST�� ������ ��� -> ���� å �����
	@RequestMapping(value="/create", method= RequestMethod.POST)
	public ModelAndView createPost(@RequestParam Map<String, Object> map) {
		ModelAndView mav = new ModelAndView();
		System.out.println(map.toString());
		//{title=aadj, category=bbdj, price=8764, book_id=4}
		String bookId = this.bookService.create(map);
		if(bookId==null) {
			mav.setViewName("redirect:/create");
		} else {
			mav.setViewName("redirect:/detail?bookId="+bookId); //������ å�� �������� �̵�
		}
		
		return mav;
	}
	
	
	@RequestMapping(value="/detail", method= RequestMethod.GET)
	public ModelAndView detail(@RequestParam Map<String, Object> map) {
		System.out.println("detail");
		System.out.println(map);
		Map<String, Object> detailMap = this.bookService.detail(map);
		
		ModelAndView mav = new ModelAndView();
		mav.addObject("data", detailMap);
		String bookid = map.get("bookId").toString();
		mav.addObject("bookId", bookid);
		mav.setViewName("/book/detail");
		
		System.out.println("mav");
		System.out.println(mav);
		
		return mav;
	}
	
	
	@RequestMapping(value="/update", method=RequestMethod.GET)
	public ModelAndView update(@RequestParam Map<String, Object> map) {
		Map<String, Object> detailMap = this.bookService.detail(map);
		
		ModelAndView mav= new ModelAndView();
		mav.addObject("data", detailMap);
		mav.setViewName("/book/update");
		System.out.println("mav : update : GET");
		System.out.println(mav);
		return mav;
	}
	
	@RequestMapping(value="update", method=RequestMethod.POST) 
	public ModelAndView udpatePost(@RequestParam Map<String, Object> map) {
		ModelAndView mav = new ModelAndView();
		boolean isUpdateSuccess = this.bookService.edit(map);
		if(isUpdateSuccess) {
			String bookId = map.get("bookId").toString();
			mav.setViewName("redirect:/detail?bookId="+bookId);
		} else {
			mav=this.update(map);
		}
		
		return mav;
	}
	
	@RequestMapping(value="/delete", method=RequestMethod.POST)
	public ModelAndView deletePost(@RequestParam Map<String,Object> map) {
		ModelAndView mav = new ModelAndView();
		boolean isDeleteSuccess = this.bookService.remove(map);
		if(isDeleteSuccess) {
			mav.setViewName("redirect:/list");
		} else {
			String bookId = map.get("bookId").toString();
			mav.setViewName("redirect:/detail?bookId="+bookId);
		}
		return mav;
	}
	
	@RequestMapping(value="list")
	public ModelAndView list(@RequestParam Map<String, Object> map) {
		System.out.println("list");
		System.out.println(map);
		List<Map<String, Object>> list = this.bookService.list(map);
		ModelAndView mav = new ModelAndView();
		
		mav.addObject("data",list);
		
		if(map.containsKey("keyword")) {
			mav.addObject("keyword", map.get("keyword"));
		}
		
		
		mav.setViewName("/book/list");
		return mav;
	}
	
	
}







