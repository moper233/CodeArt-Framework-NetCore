﻿1.领域事件机制需要创建独立的数据库，也就是说，两个领域之间的通讯，要保证这两个领域用的数据库不同，这是因为队列算法会传递事件条目，而事件条目会在被调用方创建对应的队列（调用队列的编号、事件条目的编号、被调用队列的编号有可能相同）。
所以服务的数据库是独立的。