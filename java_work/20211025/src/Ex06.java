import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.Font;

public class Ex06 {
	
	/*
	 * html css -> position absoulute ... 절대좌표..
	 * 
	 * absoulute layout  좌표로 
	 * 
	 * 
	 * jlabel	// 라벨 글자 다는거...
	 * jtextfiled	// 글자 넣는 거...
	 * jbutton		// 버튼... 
	 * 
	 */
	
	private JFrame frame;
	private JTextField textField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Ex06 window = new Ex06();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Ex06() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 426);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		textField = new JTextField();
		textField.setBounds(283, 47, 116, 21);
		frame.getContentPane().add(textField);
		textField.setColumns(10);
		
		JButton btnNewButton_3 = new JButton("New button");
		btnNewButton_3.setBounds(22, 92, 200, 200);
		btnNewButton_3.addActionListener(
				(e)->{
					System.out.println("ㅅㄷㄴㅅ");
					for (int i =0; i< 9;i++) {
						System.out.println("i = "+i);
					}
				}
		);
		frame.getContentPane().add(btnNewButton_3);
		
		JLabel lblNewLabel = new JLabel("hihi");
		lblNewLabel.setFont(new Font("가는안상수체", Font.BOLD, 45));
		lblNewLabel.setBounds(100, 22, 116, 29);
		frame.getContentPane().add(lblNewLabel);
	}
}
