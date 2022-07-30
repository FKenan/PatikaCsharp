import java.util.ArrayList;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Main {
    public static void main(String[] args) {
        ExecutorService exec = Executors.newFixedThreadPool(4);

        ArrayList<Integer> arr = new ArrayList<>();
        for (int i =0 ;i<100 ; i++){
            arr.add(i);
        }

        Threadad thread = new Threadad(arr);
        exec.execute(thread);
    }
}
