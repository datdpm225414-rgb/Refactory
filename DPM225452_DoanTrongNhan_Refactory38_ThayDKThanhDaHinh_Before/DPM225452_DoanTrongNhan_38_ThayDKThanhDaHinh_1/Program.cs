//Thay thế Điều kiện bằng Đa hình
public class Bird
{
    public double GetSpeed()
    {
        int EUROPEAN = 1;
        switch (type)
        {
            case EUROPEAN:
                return GetBaseSpeed();
            case AFRICAN:
                return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;//10,8,6
            case NORWEGIAN_BLUE:
                return isNailed ? 0 : GetBaseSpeed(voltage);
            default:
                throw new Exception("Should be unreachable");
        }
    }
}