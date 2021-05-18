import javax.swing.JFrame;
import javax.swing.JTextArea;

class WritePad
{
    public static void main(String[] args) {
        JFrame window = new JFrame();
        JTextArea textArea = new JTextArea();
        
        textArea.setBounds(400, 100, 1300, 600);
        window.setSize(900, 800);
        window.add(textArea);
        window.setLayout(null);
        window.setVisible(true);
    }
}