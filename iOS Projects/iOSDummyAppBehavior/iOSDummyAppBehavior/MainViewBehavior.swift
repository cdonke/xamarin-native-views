//
//  MainViewBehavior.swift
//  iOSDummyAppBehavior
//
//  Created by Christiano Donke on 02/06/20.
//  Copyright © 2020 Christiano Donke. All rights reserved.
//

import UIKit

@objc(MainViewBehavior)
public class MainViewBehavior: NSObject {
    @IBOutlet
    @objc
    public weak var lblCounter: UILabel!
    
    @IBAction
    @objc
    public func btnIncrement_OnClick(sender:UIButton) {
        var n = Int(lblCounter.text ?? "-2") ?? -2;
        n+=1;
        lblCounter.text=String(n);
    }
}
