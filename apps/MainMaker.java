import java.awt.Color;
import java.awt.Component;
import java.awt.Graphics;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FileWriter;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JTextArea;
import javax.swing.border.Border;
import javax.swing.plaf.basic.BasicBorders.ButtonBorder;



class MainMaker // This class is no longer updated.It is recommended to use the MainMaker's Terminal form in FalconXOS
{
    public static void main(String[] args) {
        // Window elements
        JFrame window = new JFrame();
        JTextArea textArea = new JTextArea();
        JTextArea textArea1 = new JTextArea();
        JTextArea textArea2 = new JTextArea();
        JTextArea textArea3 = new JTextArea();
        JButton button = new JButton();
        
       window.setBounds(500, 100, 1000, 500);
        
        textArea.setBounds(100, 100, 100, 20);
        textArea1.setBounds(100, 150, 100, 20);
        textArea2.setBounds(100, 200, 100, 20);
        textArea3.setBounds(100, 250, 100, 20);
        button.setBounds(700, 135, 120, 40);
        button.addActionListener(
            (ActionListener) new ActionListener(){

                @Override
                public void actionPerformed(ActionEvent e) {
                 
                    
                }
              

                
            }
        );
                
                
        // Implement in window
        window.setLayout(null);
        window.setVisible(true);
        window.add(textArea);
        window.add(textArea1);
        window.add(textArea2);
        window.add(textArea3);
        window.add(button);
        
    }
}
