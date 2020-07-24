package com.microsoft.premier.AndroidDummyApp;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
public class MainActivity extends AppCompatActivity {

    private MainActivityBehavior _behavior;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        counter_label = _activity.findViewById(R.id.counter_label);
        button_increment = _activity.findViewById(R.id.button_increment_counter);

        button_increment.setOnClickListener(mButtonListener);
    }

    private View.OnClickListener mButtonListener = new View.OnClickListener() {
        public void onClick(View v) {
            Integer n = Integer.parseInt((String)counter_label.getText());
            ++n;
            counter_label.setText(n.toString());
        }
    };
}