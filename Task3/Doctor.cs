class  Doctor
{
    private string _fullName;
    private string _speciality;
    private int _experience;

    public Doctor()
    {
        
    }
    public Doctor(string fullName, string speciality)
    {
        _fullName = fullName;
        _speciality = speciality;
    }
    public Doctor(string fullName,string speciality, int experience)
    {
        _fullName = fullName;
        _speciality = speciality; 
        _experience = experience;
    } 
    public string TreatPatient(string patientName)
    {
        return ($"{_fullName}, {_speciality}, лечит пациента по имени {patientName}");
    } 
    public string PerformMedicalExamination(string patientName)
    {
        return $"{_fullName} проводит медицинское обследование для пациента по имени {patientName}";
    } 
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{_fullName} назначает {medication} пациенту по имени {patientName}";
    } 
    public void SetExperience(int years)
    {
        _experience=years;
    } 
    public int GetExperience()
    {
        return _experience;
    }
}