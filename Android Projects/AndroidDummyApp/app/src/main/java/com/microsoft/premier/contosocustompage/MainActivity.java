package com.microsoft.premier.contosocustompage;

import androidx.appcompat.app.AppCompatActivity;

import android.content.res.Resources;
import android.os.Bundle;

import com.microsoft.premier.activitybehaviors.MainActivityBehavior;

public class MainActivity extends AppCompatActivity {

    private MainActivityBehavior _behavior;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        _behavior = new MainActivityBehavior(this);
        _behavior.SetupInterface(R.id.counter_label, R.id.button_increment_counter);
    }
}