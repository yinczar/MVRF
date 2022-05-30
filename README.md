# MVRF
**注意 ： Unity版本要求小于 2020.x ， 推荐版本 2019.4.28f1c1**

**内含插件：**
**SteamVR v2.7.3 + ViveInputUtility**

## 教程

1.新建项目导入插件 [**“MVRF.unitypackage”**](https://github.com/yinczar/MVRF/blob/main/Unitypackage/MVRF.unitypackage)，**导入后Editor会提示报错，可以先不管**；

![image](https://user-images.githubusercontent.com/34049856/170965320-97d3af3d-795b-4a08-80f6-ea6eb90535f9.png)

2.双击导入(*Assets>MVRFVivePackages*) 路径下的 **SteamVR Plugin** ，依然可以忽略Editor报错；

![image](https://user-images.githubusercontent.com/34049856/170966305-58daab11-7fa4-4dd8-a16f-f19d1eb40968.png)

3.双击导入(*Assets>MVRFVivePackages*) 路径下的 **VIVE Input Utility** 

![image](https://user-images.githubusercontent.com/34049856/170967017-c86b7da5-2193-4346-b492-0a92fc86a90f.png)

导入完成后会弹出以下窗口，选择 **Unity XR**；

![image](https://user-images.githubusercontent.com/34049856/170967213-88e8eccd-a0d7-42fd-84ae-81b238056fb1.png)

以下按步骤做即可

![image](https://user-images.githubusercontent.com/34049856/170967470-de91b346-d63c-43e4-aa26-f5f1a807bda3.png)

![image](https://user-images.githubusercontent.com/34049856/170967578-1cc0ec62-32a9-4023-9bef-025dafa76031.png)

![image](https://user-images.githubusercontent.com/34049856/170967616-de76df31-2da9-4e33-b5e4-8ff36e8cd543.png)

4. 删除场景内的 **Main Camera** 并在Hirarchy面板右键选择**Create VRF**

![image](https://user-images.githubusercontent.com/34049856/170968227-42586d9d-5331-43f2-a518-bfcd79945d2b.png)

创建一个Plane右键 *MVRF>SetAsTeleportArea*， 即可实现基础手柄传送；

![image](https://user-images.githubusercontent.com/34049856/170968622-07a977b4-0797-4502-a807-e7a8fcefbe46.png)![image](https://user-images.githubusercontent.com/34049856/170969041-f67535ad-0725-458e-828e-caf10f9bead0.png)



